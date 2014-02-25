using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Microsoft.Windows.Controls.Ribbon;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using WaveCalculator.Lib;
using WaveCalculator.Controls;



namespace calculator_wht
{
    /// <summary>
    /// Interaction logic for HudsonWindow.xaml
    /// </summary>

    public partial class HudsonWindow : RibbonWindow
    {
        WaveCalculator.Lib.HudsonCalculator Hudsoncalculator;

        public HudsonWindow()
        {
            InitializeComponent();
            Hudsoncalculator = new WaveCalculator.Lib.HudsonCalculator();
        }

        private void hbox_L_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate_Click(object sender, RoutedEventArgs e)
        {
            var lambda = double.Parse(hbox_L.Text);
            var h = double.Parse(hbox_h.Text);
            var alpha = double.Parse(hbox_alpha.Text);
            var KD = double.Parse(hbox_KD.Text);
            var l = double.Parse(hbox_l.Text);

            alpha = (Math.PI / 180) * alpha;

            var result = Hudsoncalculator.Calculate(lambda, l, h, KD, alpha);

            Result.Content = result.state;
            ResultWaveT.Content = Math.Round(result.T, 2);
            ResultWavef.Content = Math.Round(result.f, 2);
            ResultDispR.Content = Math.Round(result.omega, 3);
            ResultWavek.Content = Math.Round(result.k, 3);

            ResultHudsonForce.Content = Math.Round(result.HudsonForce, 2);
            ResultHd.Content = Math.Round(result.Hd, 2);
            ResultNS.Content = Math.Round(result.NS, 2);
            ResultSR.Content = Math.Round(result.SR, 2);
            ResultWR.Content = Math.Round(result.WR, 2);

        }

    }

}
