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
using meth;

namespace pr10._3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double r = 0;
        double a = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ba_Click(object sender, RoutedEventArgs e)
        {
            ta.Clear();
            tb.Clear();
            a = Convert.ToDouble(td.Text);
            r = Convert.ToDouble(tc.Text);
            ta.Text += "Square: " + meth.math.Circlesr(r) + " ;" + Environment.NewLine + "perimeter: " + meth.math.Circlesr(r) + " .";
            tb.Text += "Square: " + meth.math.Squarer(a) + " ;" + Environment.NewLine + "perimeter: " + meth.math.Squarep(a) + " .";
        }
    }
}
