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
            #region calculadora
            //Inicio:
            //    Console.Clear();
            //    Console.Write("Digite o primeiro numero: ");
            //    double num1 = double.Parse(Console.ReadLine());
            //    Console.Write("Digite o segundo numero: ");
            //    double num2 = double.Parse(Console.ReadLine());

            //    Console.WriteLine("Selecione a operação (+ - x /): ");
            //    char op = char.Parse(Console.ReadLine());
            //    double resultado = 0;
            //    switch (op)
            //    {
            //        default:
            //            Console.WriteLine("Error, Escolha a opção válida");
            //            break;
            //        case '+':
            //        case 'l':
            //            resultado = num1 + num2;
            //            break;
            //        case '-':
            //            resultado = num1 - num2;
            //            break;
            //        case 'x':
            //            resultado = num1 * num2;
            //            break;
            //        case '/':
            //            if (num2 == 0)
            //            {
            //                Console.WriteLine("Não é possivel dividir por 0");
            //                Console.ReadKey();
            //                goto Inicio;
            //            }

            //            else
            //                resultado = num1 / num2;


            //            break;
            //    }
            //    Console.WriteLine($"O resultado é {resultado}");
            //    Console.WriteLine("Continuar Calculando (s / n)?");
            //    string opcao = Console.ReadLine();
            //    if (opcao == "s" || opcao == "S")
            //    {
            //        goto Inicio;
            //    }
            #endregion

            #region Fibonnaci
            // 1 2 R 2 R 2 R 2 R 2 R 2  R 2  
            // 0+1 1+1 2+1 3+2 5+3 8+5 13+8
            int n1 =0, n2=1, res=0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{res} ");
                res = n1+n2;
                n2 = n1;
                n1 = res;
            }
            Console.ReadKey();
            
            #endregion
        }
    }
}
