
using System;
using System.Collections.Generic;
using System.IO;
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

namespace encriptacion 
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
           
          
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string a;
            Random ride = new Random();
            int pi= ride.Next(0,228);
            int p = ride.Next(0, 500);
            int q = ride.Next(0, 500);
            int fj = pi;
            a = pe.Text;
            StreamWriter f = new StreamWriter("D:\\mensaje.txt");
            f.Write("frase "+a+ " semilla "+pi+" llaves p y q "+p+" "+q);
            f.Close(); 
            collatz iam = new collatz();
            iam.sec(fj);
            iam.proceso(a);
           desencriptar na = new desencriptar();
            na.rsa(fj, p, q);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
         Window1 cp = new Window1();
         cp.Show();
        }
    }
}
