using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace encriptacion
{
    class desencriptar:collatz
    {
        public int lla { get; set; }
        public string me { get; set; }  
       public void procso(int ca)
        {
            this.lla = ca;
            for (int i = 0; i < ca; i++)
            {
                List<int> a = new List<int>();
                int wi = ca;
                //usamos un for para que encaso de usar una lista el contador recorra cada posicion
                while (wi != 1 && wi != 2 && wi != 4)
                {

                    if (wi % 2 == 0)
                    {
                        //hay que definir dentro del if orque si no existe un margen de error por que la variable wi no guarda su valor
                        wi = wi / 2;
                        a.Add(wi);
                        string jfjf = string.Join(" ", a);
                        StreamWriter d = new StreamWriter("D:\\numero.txt");
                        d.Write(" " + jfjf + " ");
                        d.Close();
                    }

                    if (wi % 2 == 1)
                    {
                        wi = (wi * 3) + 1;
                        a.Add(wi);
                        string jfjf = string.Join(" ", a);
                        StreamWriter d = new StreamWriter("D:\\numero.txt");
                        d.Write(" " + jfjf + " ");
                        d.Close();
                    }
                }
                break;



            }
        }
      public void desencriptado(string des)
        {
            this.me = des;
            List<string> alfabeto = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "\\", "|", ";", ":", "'", "\"", ",", ".", "<", ">", "?", "/", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };
            string[] li = File.ReadAllLines("D:\\numero.txt");
            List<int> numbers = new List<int>();
            foreach (string line in li)
            {
                foreach (string p in line.Split(" "))
                {
                    int n;
                    if (int.TryParse(p, out n))
                    {
                        numbers.Add(n);
                    }
                }
            }
            string separador = "";
            string down = des;
            StreamWriter ghk = new StreamWriter("D:\\desencriptado.txt");
            for (int i =0; i <down.Length ; i++)
            {
              
                    if (i < numbers.Count)
                    {
                        int dis = numbers[i];
                        char letra = down[i];
                        if (alfabeto.Contains(letra.ToString()))
                        {
                            int posicion = alfabeto.IndexOf(letra.ToString());
                            int posicionFinal = (posicion-dis) % alfabeto.Count;
                            char letraencriptada = alfabeto[posicionFinal][0];
                            separador += letraencriptada;
                        }
                        else
                        {
                            MessageBox.Show("xd");
                        }
                    }
                    else
                    {
                        break;
                    }
            }
            ghk.Write("mensaje desencriptado "+separador);
            ghk.Close();
            MessageBox.Show(separador);
        }
        public void rsa(int r,int q,int p)
        {
            this.lla = r;
            this.la= q;
            this.a = p;
            int n = p * q;
            int mh = n/p;
            int O= (p-1)*(q-1);
            int MCD = O / r;
            StreamWriter LLave = new StreamWriter(("D:\\llavesita.txt"));
            LLave.Write("llave encriptada :"+O+" llave principal y secumdaria "+n);
            LLave.Close();
            StreamWriter LLav = new StreamWriter(("D:\\llavesi.txt"));
            LLav.Write("llave desencriptada :" + MCD + " llave principal y secumdaria " + mh);
            LLav.Close();
        }
    }
}
