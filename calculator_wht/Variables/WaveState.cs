using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveCalculator.Variables
{
    public class PhysicalConstants
    {
        public double RhoRock { get; set; }
        public double RhoWater { get; set; }
        public double g { get; set; }
        public double nu { get; set; }
        public double mu { get; set; }
    }    

     public class WaveProperties : PhysicalConstants
    {
        public double k { get; set; }
        public double omega { get; set; }
        public double T { get; set; }
        public double f { get; set; }
        public double u { get; set; }
        public string state { get; set; }
    }
        
     public class WaveState : WaveProperties
    {
        public double c {get; set;}
        public double cg {get; set;}
        public double Hs { get; set; }

        public double E { get; set; }
        public double P {get; set;}
    }

     public class HudsonState : WaveProperties
    {
        public double l { get; set; }
        public double alpha { get; set; }

        public double beta { get; set; }
        public double HudsonForce { get; set; }

        public double Hd { get; set; }
        public double NS { get; set; }
        public double SR { get; set; }
        public double Const { get; set; }
        public double gammaR { get; set; }
        public double WR { get; set; }

    }


}
