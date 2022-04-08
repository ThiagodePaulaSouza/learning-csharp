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
            #region entrada
            string nome1, nome2, nome3, nome4, aux;

            Console.WriteLine("digite o nome #1: ");
            nome1 = Console.ReadLine();
            Console.WriteLine("digite o nome #2: ");
            nome2 = Console.ReadLine();
            Console.WriteLine("digite o nome #3: ");
            nome3 = Console.ReadLine();
            Console.WriteLine("digite o nome #4: ");
            nome4 = Console.ReadLine();
            #endregion

            #region inverter
            aux = nome1;
            nome1 = nome4;
            nome4 = aux;

            aux = nome2;
            nome2 = nome3;
            nome3 = aux;
            #endregion

            #region mostrar
            Console.WriteLine();
            Console.WriteLine("nome invertivo na sequência invertida");
            Console.WriteLine(nome1);
            Console.WriteLine(nome2);
            Console.WriteLine(nome3);
            Console.WriteLine(nome4);
            Console.ReadKey();
            #endregion

        }
    }
}
