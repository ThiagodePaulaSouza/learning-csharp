using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TesteConsole
    {
        static void Main(string[] args)
        {
            #region Conversão Implícita
            //byte num1 = 12;
            //ushort num2;

            //float num3 = 123.1f;
            //double num4;

            //char letra = 'C';
            //int numero = 'C';

            //Console.WriteLine($"inteiros: {num2 = num1}\nDecimais {num4 = num3}\nCaracter {letra} em int é {numero}");
            //Console.ReadKey();
            #endregion

            #region Conversão Explícita
            //ushort num1 = 100;
            //byte num2 = (byte)num1;

            //float num3 = 078123.0189272f;
            //int num4 = (int)num3;

            //char letra = (char)12;

            //Console.WriteLine(num2);
            //Console.WriteLine(num3);
            //Console.WriteLine(letra);
            //Console.ReadKey();
            #endregion

            #region Método Parse
            //string textoNumero = "1985";
            //int numero = int.Parse(textoNumero); //erro System.FormatException: 'A cadeia de caracteres de entrada não estava em um formato correto.'

            //byte num1 = byte.Parse("123");
            //double num2 = double.Parse("62,213");//depende da linguagem do sistema (en = .) || (br = ,)


            //Console.WriteLine(numero);
            //Console.WriteLine(num1);
            //Console.WriteLine(num2);
            //Console.ReadKey();
            #endregion

            #region Metodo Converse

            //string texto = Convert.ToString(5486795306798);
            //double num1 = Convert.ToDouble(true);

            //Console.WriteLine(texto);
            //Console.WriteLine(num1);
            //Console.ReadLine();

            #endregion
        }
    }
}
