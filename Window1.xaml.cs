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
using System.Windows.Shapes;

namespace encriptacion
{
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string mensaje,llave;
            llave = lla.Text;
            int entero=Convert.ToInt32(lla.Text);
            mensaje = men.Text;
            StreamWriter text = new StreamWriter("D:\\llave.txt");
            text.Write(llave);
            text.Close();
            StreamWriter baby= new StreamWriter("D:\\men.txt");
            baby.Write(mensaje);
            baby.Close();
            desencriptar fgh= new desencriptar();
            fgh.procso(entero);
            fgh.desencriptado(mensaje);
        }
         private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 xd= new Window2();  
            xd.Show();  
        }
    }
}
