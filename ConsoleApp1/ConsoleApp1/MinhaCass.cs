using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MinhaCass
    {
        public void AumentarValor(int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final é: {valor}");
        }
        // ref tudo que for alterado altera na var original
        public void AumentarRef(ref int valor)
        {
            valor += 10;
            Console.WriteLine($"O valor final é: {valor}");
        }
    }
}
