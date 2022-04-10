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
        //calculadora
        Inicio:
            Console.Clear();
            Console.Write("Digite o primeiro numero: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            double num2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a operação (+ - x /): ");
            char op = char.Parse(Console.ReadLine());
            double resultado=0;
            switch (op)
            {
                default:
                    Console.WriteLine("Error, Escolha a opção válida");
                    break;
                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case 'x':
                    resultado = num1 * num2;
                    break;
                case '/':
                    if (num2 == 0)
                    {
                        Console.WriteLine("Não é possivel dividir por 0");
                        Console.ReadKey();
                        goto Inicio;
                    }
                        
                    else
                        resultado = num1 / num2;
                    
                    
                    break;
            }
            Console.WriteLine($"O resultado é {resultado}");
            Console.WriteLine("Continuar Calculando (s / n)?");
            string opcao = Console.ReadLine();
            if (opcao == "s" || opcao == "S")
            {
                goto Inicio;
            }
        }
    }
}
