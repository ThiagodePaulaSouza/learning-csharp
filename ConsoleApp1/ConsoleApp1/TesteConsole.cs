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
            //Multiplicação de Matriz
            int[,] m1 = new int[2, 3];
            int[,] m2 = new int[3, 2];
            int[,] resultado = new int[2, 2];

            Console.WriteLine("PREENCHA A MATRIZ 1");
            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 3; coluna++)
                {
                    Console.Write($"#1. posição [{linha}][{coluna}] = ");
                    m1[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("\nPREENCHA A MATRIZ 2");
            for (int linha = 0; linha < 3; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    Console.Write($"#2. posição [{linha}][{coluna}] = ");
                    m2[linha, coluna] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\nResultado da Matriz #1 x Matriz #2");
            for (int i = 0; i < 2; i++)
                for (int j = 0; j < 2; j++)
                    for (int k = 0; k < 3; k++)
                        resultado[i, j] += m1[i, j] * m2[k, j];
            Console.WriteLine($"[{resultado[0, 0]}][{resultado[0, 1]}]");
            Console.WriteLine($"[{resultado[1, 0]}][{resultado[1, 1]}]");
            Console.ReadKey();
        }
    }
}
