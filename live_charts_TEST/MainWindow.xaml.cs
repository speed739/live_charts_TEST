using System;
using System.Collections.Generic;
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
using LiveCharts;
using LiveCharts.Helpers;
using LiveCharts.Wpf;

namespace live_charts_TEST
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double i = 0, x = 0, y = 0, z = 0;

        public Func<ChartPoint, string> PointLabel { get; set; }

        public MainWindow()
        {
            InitializeComponent();
        }
        public void Change_Chart_Values()
        {
           

        }
        private void Chart_OnDataClick(object sender, ChartPoint chartPoint)
        {
            


            //|var chart = (LiveCharts.Wpf.PieChart)chartPoint.ChartView;

            ////clear selected slice.
            //foreach (PieSeries series in chart.Series)
            //    series.PushOut = 0;

            //var selectedSeries = (PieSeries)chartPoint.SeriesView;
            //selectedSeries.PushOut = 8;
        }

        private void btn_a_Click(object sender, RoutedEventArgs e)
        {
            i++;
            List<double> list = new List<double>() {i};
            part_blue.Values = list.AsChartValues();
          
        }
        private void btn_b_Click(object sender, RoutedEventArgs e)
        {
            x++;
            List<double> list = new List<double>() { x };
            part_red.Values = list.AsChartValues();
        }

        private void btn_c_Click(object sender, RoutedEventArgs e)
        {
            y++;
            List<double> list = new List<double>() { y };
            part_yellow.Values =  list.AsChartValues();

        }

    }
}
