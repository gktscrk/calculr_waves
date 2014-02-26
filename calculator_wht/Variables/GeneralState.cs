using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveCalculator.Variables
{
    public class GeneralState : WaveState
    {
        public double FroudeN { get; set; }
        public double ReynoldsN { get; set; }

        public double LaplaceN { get; set; }
        public double WeberN { get; set; }
        public double StokesN { get; set; }
        public double KeuleganN { get; set; }

    }

    public class FroudeState : GeneralState
    {

    }

    public class KeuleganState : GeneralState
    {
        public double A {get ; set; }

    }

    public class ReynoldsState : GeneralState
    {

    }


}
