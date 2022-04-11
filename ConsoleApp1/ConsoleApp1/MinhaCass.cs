using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MinhaCass
    {
        //delegate serve pra armazenasr ref ded metodos que tem o mesmo formato que foi declarado
        public void Somar(int n1, int n2)
        {
            Console.WriteLine($"a soma é {n1 + n2}");
        }
        public void Subtrair(int n1, int n2)
        {
            Console.WriteLine($"a subtração é {n1 - n2}");
        }
        public void Multiplicar(int n1, int n2)
        {
            Console.WriteLine($"a multiplicação é {n1 * n2}");
        }
        public void Dividir(int n1, int n2)
        {
            Console.WriteLine($"a divisão é {n1 / n2}");
        }
    }
}
