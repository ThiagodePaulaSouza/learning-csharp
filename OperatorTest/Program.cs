namespace OperatorTest;

class Program
{
    static void Main(string[] args)
    {
        new Teste1();
    }
};


public class Teste1
{
    public Teste1()
    {
        Console.WriteLine(this + this);
        Console.WriteLine(this - this);
        Console.WriteLine(this * this);
        Console.WriteLine(this / this);

        Console.WriteLine(!this);
        Console.WriteLine(this == this);
        Console.WriteLine(this != this);
        Console.WriteLine(this >= this);
        Console.WriteLine(this <= this);
        Console.WriteLine(this >> this);
        Console.WriteLine(this >>> this);
        Console.WriteLine(this << this);

        Console.WriteLine(this | this);
        Console.WriteLine(this ^ this);
        Console.WriteLine(this % this);
    }

    public static Teste1 operator ++(Teste1 a) => a;
    public static Teste1 operator --(Teste1 a) => a;

    public static bool operator false(Teste1 a) => true;
    public static bool operator true(Teste1 a) => false;

    public static string operator !(Teste1 a) => "bom dia";
    public static int operator +(Teste1 a, Teste1 b) => 42;
    public static int operator -(Teste1 a, Teste1 b) => 3;
    public static int operator *(Teste1 a, Teste1 b) => 2;
    public static int operator /(Teste1 a, Teste1 b) => 1;

    public static int operator >=(Teste1 a, Teste1 b) => 56;
    public static int operator <=(Teste1 a, Teste1 b) => 78;
    public static int operator ==(Teste1 a, Teste1 b) => 99;
    public static int operator !=(Teste1 a, Teste1 b) => 0000000;

    public static int operator >>(Teste1 a, Teste1 b) => 1112;
    public static int operator >>>(Teste1 a, Teste1 b) => 222_332;
    public static int operator <<(Teste1 a, Teste1 b) => 4546;
    public static int operator |(Teste1 a, Teste1 b) => 67;
    public static int operator ^(Teste1 a, Teste1 b) => 41;
    public static int operator %(Teste1 a, Teste1 b) => 42;
};

