using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace encriptacion
{
    class collatz
    {
        public int dato { get; set; }
        public string pa { get; set; }
        public void sec(int da)
        {
            this.dato = da;
            for (int i = 0; i < da; i++)
            {
                List<int> a = new List<int>();
                int wi = da;
                //usamos un for para que encaso de usar una lista el contador recorra cada posicion
                while (wi != 1 && wi != 2 && wi != 4)
                {

                    if (wi % 2 == 0)
                    {
                        //hay que definir dentro del if orque si no existe un margen de error por que la variable wi no guarda su valor
                        wi = wi / 2;
                        String al = Convert.ToString(wi);
                        MessageBox.Show("bucle collatz" + al);
                        a.Add(wi);
                        string jfjf = string.Join(" ", a);
                        StreamWriter d = new StreamWriter("D:\\mensje.txt");
                        d.Write(" " + jfjf + " ");
                        d.Close();
                    }

                    if (wi % 2 == 1)
                    {
                        wi = (wi * 3) + 1;
                        String al = Convert.ToString(wi);
                        MessageBox.Show("bucle collatz" + al);
                        a.Add(wi);
                        string jfjf = string.Join(" ", a);
                        StreamWriter d = new StreamWriter("D:\\mensje.txt");
                        d.Write(" " + jfjf + " ");
                        d.Close();
                    }
                }
                break;



            }
        }
        public void proceso(string pro)
        {
            this.pa = pro;
            List<string> alfabeto = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z", "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "-", "_", "+", "=", "{", "}", "[", "]", "\\", "|", ";", ":", "'", "\"", ",", ".", "<", ">", "?", "/", "À", "Á", "Â", "Ã", "Ä", "Å", "Æ", "Ç", "È", "É", "Ê", "Ë", "Ì", "Í", "Î", "Ï", "Ð", "Ñ", "Ò", "Ó", "Ô", "Õ", "Ö", "Ø", "Ù", "Ú", "Û", "Ü", "Ý", "Þ", "ß", "à", "á", "â", "ã", "ä", "å", "æ", "ç", "è", "é", "ê", "ë", "ì", "í", "î", "ï", "ð", "ñ", "ò", "ó", "ô", "õ", "ö", "ø", "ù", "ú", "û", "ü", "ý", "þ", "ÿ" };
            string[] li = File.ReadAllLines("D:\\mensje.txt");
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
                }//en esta parte sacamos un mensaje de texto postriormente con el foreach agregamos el texto en una cadena dentro de la lista que tenemos
            }
            string separador = "";
            string down = pro;
            StreamWriter ghk = new StreamWriter("D:\\so.txt");
            for (int i = 0; i < down.Length; i++)
            {
                if (i < numbers.Count)
                {
                    int des = numbers[i];
                    char letra = down[i];
                    if (alfabeto.Contains(letra.ToString()))
                    {
                        int posicion = alfabeto.IndexOf(letra.ToString());
                        int posicionFinal = (posicion + des) % alfabeto.Count;
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
            // en este bucle lo que hacemos  es encontrar la pocision de cada una de las letras y su pocision respectiva
            ghk.Write(separador);
            ghk.Close();
            //hecho por kernelboy34
        }
    }
}
