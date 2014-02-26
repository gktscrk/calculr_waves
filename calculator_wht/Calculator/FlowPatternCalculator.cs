using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MathNet.Numerics;


namespace WaveCalculator.Variables
{
    public class FlowPatternCalculator
    {
        public FroudeState Calculate1(double d, double h, double lambda)
        {
            var result = new FroudeState();

            double c, g, omega, k, T, f, kh, FroudeN;
            
            g = 9.807;

            k = 2 * Math.PI / lambda;
            kh = k * h;
            omega = Math.Sqrt(g * k * Math.Tanh(kh));
            T = 2 * Math.PI / omega;
            f = 1 / T;

            c = omega / k;
            FroudeN = c / (Math.Sqrt(g * d));

            result.state = getState(kh);
            result.omega = omega;
            result.T = T;
            result.f = f;
            result.k = k;
            result.FroudeN = FroudeN;

            return result;
        }

        public KeuleganState Calculate2(double d, double H, double h, double lambda)
        {
            var result = new KeuleganState();

            double A, KeuleganN, T, omega, g, k, kh, f;

            g = 9.807;

            k = 2 * Math.PI / lambda;
            kh = k * h;
            omega = Math.Sqrt(g * k * Math.Tanh(kh));
            T = 2 * Math.PI / omega;
            f = 1 / T;

            A = H / 2;

            KeuleganN = A * T / d;

            result.state = getState(kh);
            result.omega = omega;
            result.T = T;
            result.f = f;
            result.k = k;
            result.KeuleganN = KeuleganN;

            return result;
        }

        public ReynoldsState Calculate3(double d, double H, double h, double lambda)
        {
            var result = new ReynoldsState();

            double ReynoldsN, T, omega, g, k, kh, f, mu, c;

            g = 9.807;
            mu = 0.000001;

            k = 2 * Math.PI / lambda;
            kh = k * h;
            omega = Math.Sqrt(g * k * Math.Tanh(kh));
            T = 2 * Math.PI / omega;
            f = 1 / T;

            c = omega / k;

            ReynoldsN = c * d / mu;

            result.state = getState(kh);
            result.omega = omega;
            result.T = T;
            result.f = f;
            result.k = k;
            result.ReynoldsN = ReynoldsN;

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
