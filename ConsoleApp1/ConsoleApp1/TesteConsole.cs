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
            //goto
            Inicio: //label
            Console.WriteLine("Escolha uma opção");
            int opcao = int.Parse(Console.ReadLine());
            int valor = 0;

            switch (opcao)
            {
                default:
                    goto Inicio;
                case 1:
                    valor += 100;
                    break;
                case 2:
                    valor += 50;
                    goto case 1;
            }
            Console.WriteLine("Valor Final " + valor);

            Console.ReadKey();
        }
    }
}
