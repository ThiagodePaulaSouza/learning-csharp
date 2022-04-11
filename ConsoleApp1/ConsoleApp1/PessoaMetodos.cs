using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //partição de uma classe || divide a classe
    partial class MinhaCass
    {
        public void Aprensentar()
        {
            Console.WriteLine("ola eu sou" + nome);
        }

        public static int CalcularIdade(int anoNascimento)
        {
            return DateTime.Now.Year - anoNascimento;
        }
    }
}
