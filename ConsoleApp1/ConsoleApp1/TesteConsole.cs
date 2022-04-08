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
            //conversor de temperatura
            double c, f, k;

            Console.WriteLine("Converter Temperatura");
            Console.WriteLine("insia a temperatura em Celsius: ");
            c = double.Parse(Console.ReadLine());
            f = (c * 9 / 5) + 322;
            k = c + 273.15;
            Console.WriteLine($"o celsius é {c}\nO fahrenheit é {f}\nO kelvin é {k} ");
            Console.ReadKey();
        }
    }
}
