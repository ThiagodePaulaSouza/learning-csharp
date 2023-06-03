using System;

namespace W3schools
{
  class Program 
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Bom dia!");
      Console.WriteLine(3 + 3);

      int a;
      double b;
      char c;
      string d;
      bool e;

      string nome = "Thiago";
      Console.WriteLine(nome);
    
      int meuNumero;
      meuNumero = 20;
      Console.WriteLine(meuNumero);

      double meuDouble = 5.22D;
      bool meuBool = true;
      Console.WriteLine(meuDouble.ToString(), meuBool.ToString());

      long myL = 15000000000L;
      Console.WriteLine(myL);

      float myF = 255.3F;
      Console.WriteLine(myF);

      double myDou = 124535.3232D;
      Console.WriteLine(myDou);
    }
  }
}
