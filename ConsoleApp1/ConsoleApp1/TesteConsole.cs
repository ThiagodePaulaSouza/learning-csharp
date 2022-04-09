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
            //imc peso / (altura²)
            Console.WriteLine("calcular IMC");

            Console.WriteLine("Digite o peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o altura: ");
            double altura = double.Parse(Console.ReadLine());

            double IMC = peso / (altura * altura);
            if (IMC < 20)
            {
                Console.WriteLine($"\n{IMC} você está MUITO MAGRO");
            }
            else if (IMC >= 20 && IMC <=24)
            {
                Console.WriteLine($"\n{IMC} você está NORMAL");
            }
            else if (IMC >= 25 && IMC <= 29)
            {
                Console.WriteLine($"\n{IMC} você está GORDO");
            }
            else if (IMC >= 30 && IMC <= 34)
            {
                Console.WriteLine($"\n{IMC} você está MUITO GORDO");
            }
            else
            {
                Console.WriteLine($"\n{IMC} você está EXTREMAMENTE GORDO");
            }


            Console.ReadKey();
        }
    }
}
