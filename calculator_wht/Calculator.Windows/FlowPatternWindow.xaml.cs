using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Microsoft.Windows.Controls.Ribbon;

using WaveCalculator.Variables;
using WaveCalculator.Controls;


namespace calculator_wht
{
    /// <summary>
    /// Interaction logic for FlowStateWindow.xaml
    /// </summary>
    public partial class FlowPatternWindow : RibbonWindow
    {
        WaveCalculator.Variables.FlowPatternCalculator FlowPatternCalculator;

        public FlowPatternWindow()
        {
            InitializeComponent();
            FlowPatternCalculator = new WaveCalculator.Variables.FlowPatternCalculator();
        }

        private void box_L_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Calculate1_Click(object sender, RoutedEventArgs e)
        {
            var lambda = double.Parse(box_L.Text);
            var h = double.Parse(box_h.Text);
            var d = double.Parse(box_d.Text);


            var result = FlowPatternCalculator.Calculate1(lambda, h, d);

            Result.Content = result.state;
            ResultWaveT.Content = Math.Round(result.T, 2);
            ResultWavef.Content = Math.Round(result.f, 2);
            ResultDispR.Content = Math.Round(result.omega, 3);
            ResultWavek.Content = Math.Round(result.k, 3);

            ResultFroudeN.Content = Math.Round(result.FroudeN, 2);

        }

        private void Calculate2_Click(object sender, RoutedEventArgs e)
        {
            var lambda = double.Parse(box_L.Text);
            var h = double.Parse(box_h.Text);
            var d = double.Parse(box_d.Text);
            var H = double.Parse(box_H.Text);

            var result = FlowPatternCalculator.Calculate2(lambda, h, d,  H);

            Result.Content = result.state;
            ResultWaveT.Content = Math.Round(result.T, 2);
            ResultWavef.Content = Math.Round(result.f, 2);
            ResultDispR.Content = Math.Round(result.omega, 3);
            ResultWavek.Content = Math.Round(result.k, 3);

            ResultKeuleganN.Content = Math.Round(result.KeuleganN, 2);

        }

        private void Calculate3_Click(object sender, RoutedEventArgs e)
        {
            var lambda = double.Parse(box_L.Text);
            var h = double.Parse(box_h.Text);
            var d = double.Parse(box_d.Text);
            var H = double.Parse(box_H.Text);

            var result = FlowPatternCalculator.Calculate3(lambda, h, d, H);

            Result.Content = result.state;
            ResultWaveT.Content = Math.Round(result.T, 2);
            ResultWavef.Content = Math.Round(result.f, 2);
            ResultDispR.Content = Math.Round(result.omega, 3);
            ResultWavek.Content = Math.Round(result.k, 3);

            ResultReynoldsN.Content = Math.Round(result.ReynoldsN, 2);

        }

        private void Open_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveProject_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Settings_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Help_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void About_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UnloadAllFiles_MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit_MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void RibbonButton_Click(object sender, RoutedEventArgs e)
        {
            HudsonWindow secondWindow = new HudsonWindow();
            secondWindow.Show();
        }

        private void RibbonButton_Click_1(object sender, RoutedEventArgs e)
        {
            MainWindow secondWindow = new MainWindow();
            secondWindow.Show();

        }

    }
}
