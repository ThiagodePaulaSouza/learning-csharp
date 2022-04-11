using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Carr : Veiculo
    {
        
        public int VelocidadeMax { get; set; }

        public override void Acelerar()
        {
            Console.WriteLine("Acelerou o Carro");
        }

        public void LigarMotor()
        {
            Console.WriteLine("liguei o motor");
        }

        public override void Parar()
        {
            Console.WriteLine("Parou o carro");
        }
    }
}
