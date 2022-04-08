using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class TesteConsole
    {
        enum xereca
        {
            minimo = 5,
            media,
            maxima
        }
        /*
         * diferença entre struct e class
         * class - reference types => valores passados por ref para o msm espaço de memoria.
         * ocupa memoria heap(espaço maior e menos performance) todos obj é acessado por referencia.
         * 
         * struct - value types => valores são copiados para um novo espaço de memoria.
         * apenas armazena tipos de valores em stack(pequeno espaço de memoria).
         */
        class Teste
        {
            public string nome = "thiago";
        }
        struct Pessoa 
        {
            public string nome { get; set; } // erro ao por: public string nome = "valor";
            public int idade;
            public double altura;
        }
        static void Main(string[] args)
        {
            Pessoa p2 = new Pessoa()
            {
                nome = "arthur",

                altura = 1,
                idade = 1,
            
                
            };

            /**
             * Escreva um programa que leia as notas das duas avaliações normais
             * e a nota da avaliação optativa.
             * Caso o aluno não tenho feito a optativa deve ser fornecido o valor -1
             * Calcular a média do semestre considerando que a prova optativa
             * substitui a nota mais baixa entre as duas primeiras avaliações.
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
            /*
             * #region Entrada
           Console.WriteLine("Escreva a nota1");
           int nota1 = int.Parse(Console.ReadLine());

           Console.WriteLine("Escreva a nota2");
           int nota2 = int.Parse(Console.ReadLine());

           Console.WriteLine("Escreva a nota optativa");
           int notaOptativa = int.Parse(Console.ReadLine());
           #endregion

           if (notaOptativa > nota1)
           {
               nota1 = notaOptativa;
           }
           if (notaOptativa > nota2)
           {
               nota2 = notaOptativa;
           }
           #region MostrarResultado
           int resultado = (nota1 + nota2) / 2;
           if (resultado >= 6)
           {
               Console.WriteLine("O aluno está: APROVADO");
           }
           if (resultado < 3)
           {
               Console.WriteLine("O aluno está: REPROVADO");
           }
           if (resultado > 3 && resultado < 6)
           {
               Console.WriteLine("O aluno está: EXAME");
           }
           #endregion
             */
             

            
        }
    }
}
