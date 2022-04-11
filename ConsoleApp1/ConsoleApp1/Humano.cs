using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Humano
    {
        //pode ser sobrescrito, pode ter implementação || tipo abstrato mas pode reescrever
        public virtual void Olhos()
        {
            Console.WriteLine("Humano tem olho");
        }
        public virtual void Cabelos()
        {
            Console.WriteLine("Humano tem cabelo");
        }
    }
    class Pessoa : Humano
    {
        public override void Cabelos()
        {
            Console.WriteLine("Pessoa tem cabelos");
        }

        public sealed override void Olhos()
        {
            Console.WriteLine("Pessoa tem olhos");
        }
    }
    class Homem : Pessoa
    {
        public override void Cabelos()
        {
            Console.WriteLine("Homem tem cabelos");
        }

        //public override void Olhos()
        //{
        //    Console.WriteLine("Homem tem olhos");
        //}
    }
}
;