﻿using System;

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

      // Implicit Casting
      int Nove = 9;
      double DNove = Nove;
      Console.WriteLine(Nove); //int
      Console.WriteLine(DNove); //double

      // Explicit Casting
      double NoveDecimal = 9.31;
      int novoIntNove = (int) NoveDecimal;
      Console.WriteLine(NoveDecimal);
      Console.WriteLine(novoIntNove);

      // Type Conversion Methods
      int Dez = 10;
      double DezDouble = 10.333;
      bool boleanoBonitao = true;
      Console.WriteLine(Convert.ToString(Dez));
      Console.WriteLine(Convert.ToDouble(Dez));
      Console.WriteLine(Convert.ToInt32(DezDouble));
      Console.WriteLine(Convert.ToString(boleanoBonitao));

      Console.WriteLine(2 | 5);
      Console.WriteLine(2 & 4);
      Console.WriteLine(9 ^ 4);
      Console.WriteLine(9 >> 4);
      Console.WriteLine(4 << 6);

      int ll = 5;
      ll &= 3;
      Console.WriteLine(ll); // 1

      int zz = 5;
      zz |= 3;
      Console.WriteLine(zz); //7

      int nn = 5;
      nn >>= 3;
      Console.WriteLine(nn); //0

      int aa = 5;
      aa <<= 3;
      Console.WriteLine(aa); // 40

      string hello = "Oi";
      Console.WriteLine(hello[1]); // O

      Console.WriteLine(hello.IndexOf("i"));

      // getting last name 
      
      string nomezin = "Thiago Souza";
      int posicaoChar = nomezin.IndexOf('S');
      string ultimoNome = nomezin.Substring(posicaoChar);
      Console.WriteLine(ultimoNome);
    }
  }
}
