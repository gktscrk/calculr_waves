using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics;


namespace WaveCalculator.Variables
{
    public class HudsonCalculator
    {
        public HudsonState Calculate(double lambda, double h, double alpha, double KD, double l)
        {
            var result = new HudsonState();

            double k, omega, T, f, kh, u;
            double beta, HudsonForce, NS, Const, gammaR, Hd, WR, SR;
            double RhoRock, RhoWater, g;

            // alpha = (Math.PI / 180) * alpha;
            KD = KD / 100;

            g = 9.807;
            RhoWater = 1000;
            RhoRock = 2500;
            beta = 0.78;

            Const = 1;

            k = 2 * Math.PI / lambda;
            kh = k * h;
            omega = Math.Sqrt(g * k * Math.Tanh(kh));
            T = 2 * Math.PI / omega;
            f = 1 / T;    

            Hd = beta * h;
            u = Math.Sqrt(1 / beta * g * Hd);

            HudsonForce = Const / beta * Math.Pow(l, 2) * RhoWater * g * Hd;

            NS = Math.Pow(MathNet.Numerics.Trig.Cotangent(alpha), 3);
            gammaR = RhoRock * g;
            SR = RhoRock / RhoWater;

            WR = (Math.Pow(Hd, 3) * gammaR) / (Math.Pow((SR - 1), 3) * KD * MathNet.Numerics.Trig.Cotangent(alpha));

            // Base properties of waves
            result.state = getState(kh);
            result.omega = omega;
            result.T = T;
            result.f = f;
            result.k = k;

            // Derived values
            result.u = u;
            result.HudsonForce = HudsonForce;
            result.Hd = Hd;
            result.SR = SR;
            result.NS = NS;
            result.WR = WR;

            return result;

        }

        private string getState(double kh)
        {
            var result = "";

            int value = Convert.ToInt32(kh);
            if (value >= Math.PI)
            {
                result = "deep";
            }
            else if (value <= Math.PI / 10)
            {
                result = "shallow";
            }
            else
            {
                result = "intermediate";
            }
            return result;
        }

    }
}
