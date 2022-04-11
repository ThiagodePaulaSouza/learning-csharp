using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //n pode ser herdada
    sealed class Bicicleta : Veiculo
    {
        public override void Acelerar()
        {
            Console.WriteLine("Acelerou a bike");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou a bike");
        }
    }
}
