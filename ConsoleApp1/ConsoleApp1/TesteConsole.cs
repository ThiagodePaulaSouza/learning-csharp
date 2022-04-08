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
            resultado[0, 0] = (m1[0, 0] * m2[0, 0]) + (m1[0, 1] * m2[1, 0]) + (m1[0, 2] * m2[2, 0]);
            resultado[1, 0] = (m1[1, 0] * m2[0, 0]) + (m1[1, 1] * m2[1, 0]) + (m1[1, 2] * m2[2, 0]);
            resultado[0, 1] = (m1[0, 0] * m2[0, 1]) + (m1[0, 1] * m2[1, 1]) + (m1[0, 2] * m2[2, 1]);
            resultado[1, 1] = (m1[1, 0] * m2[0, 1]) + (m1[1, 1] * m2[1, 1]) + (m1[1, 2] * m2[2, 1]);
            Console.WriteLine($"[{resultado[0, 0]}][{resultado[0, 1]}]");
            Console.WriteLine($"[{resultado[1, 0]}][{resultado[1, 1]}]");
            Console.ReadKey();
        }
    }
}
