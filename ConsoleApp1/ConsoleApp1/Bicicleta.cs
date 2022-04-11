using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Bicicleta : Veiculo
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
