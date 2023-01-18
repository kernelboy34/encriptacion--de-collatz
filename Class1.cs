using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Packaging;
using System.Linq;
using System.Reflection.Metadata;
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
                int wi =da;
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
        public void proceso (string pro)
        {
            this.pa = pro;
            List<char> alfabeto = new List<char>() { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'ñ', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'Ñ', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', ' ', '!', '"', '#', '$', '%', '&', '\'', '(', ')', '*', '+', ',', '-', '.', '/', ':', ';', '<', '=', '>', '?', '@', '[', '\\', ']', '^', '_', '`', '{', '|', '}', '~' };
            String[] li = File.ReadAllLines("D:\\mensje.txt");
            List<int> numbers = new List<int>();
            foreach (string line in li)
            {
                if (int.TryParse(line, out int number))
                {
                    numbers.Add(number);
                }
                else
                {
                    // maneja el error si la conversión falla
                }
            }
            int rf =1;
            for (int fgh = 0; fgh < pa.Length; fgh++)
            {
                char down = Convert.ToChar(pro);
                if (down  == alfabeto[2])
                {
                    StreamWriter ghk = new StreamWriter("D:\\so.txt");
                    ghk.Write(alfabeto[numbers[1]] + " ");
                    ghk.Close();
                }    
            }
        }
    }
}
