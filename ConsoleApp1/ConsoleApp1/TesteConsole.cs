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
            /**
             * ✔ Escreva um programa que leia as notas das duas avaliações normais
             * ✔ e a nota da avaliação optativa.
             * ✔ Caso o aluno não tenho feito a optativa deve ser fornecido o valor -1
             * ✔ Calcular a média do semestre considerando que a prova optativa
             * ✔ substitui a nota mais baixa entre as duas primeiras avaliações.
             * Escrever a média e mensagens que indiquem se o aluno foi aprovado,
             * reprovado ou está em exame, de acordo com as informações abaixo:
             * 
             * Se média for maior igual a 6
             * APROVADO
             * Se média for menor que 3
             * REPROVADO
             * Se média for maior igual a 3 e menor que 6
             * EXAME
             */

            //ler 2 notas e optativa(se n tiver nota optativa -1)
            Console.WriteLine("Escreva a nota1");
            int nota1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nota2");
            int nota2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Escreva a nota optativa");
            int notaOptativa = int.Parse(Console.ReadLine());
            
            if (notaOptativa > nota1)
            {
                nota1 = notaOptativa;
            }
            if (notaOptativa > nota2){
                nota2 = notaOptativa;
            }

            //calcular média
            int resultado = (nota1 + nota2) / 2;
            if (resultado >= 6)
            {
                Console.WriteLine("O aluno está: APROVADO");
            }
            if (resultado < 3)
            {
                Console.WriteLine("O aluno está: REPROVADO");
            }
            if(resultado >3 && resultado <6)
            {
                Console.WriteLine("O aluno está: EXAME");
            }

            //escrever situação do aluno (APROVADO/REPROVADO/EXAME)
            Console.ReadKey();
        }
    }
}
