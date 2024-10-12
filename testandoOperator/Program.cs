namespace Testando;

class Program
{
    static void Main(string[] args)
    {
        var teste = new Fraction(23, 34);
        var teste2 = new Fraction(23, 34);

        var opa = teste * teste2;

        Console.WriteLine(opa);
    }
}

public readonly struct Fraction
{
    public readonly int A;
    public readonly int B;
    public Fraction(int a, int b)
    {
        A = a;
        B = b;
    }

    public static int operator *(Fraction a, Fraction b) => 42;
}

public static class ArrayExtensions
{
    public static int[,] Times(this int[,] arr1, int[,] arr2)
    {
        int sum;
        int[,] res = new int[arr1.GetLength(0), arr2.GetLength(1)];
        for (int i = 0; i < arr1.GetLength(0); i++)
        {
            for (int j = 0; j < arr2.GetLength(1); j++)
            {
                sum = 0;
                for (int k = 0; k < arr1.GetLength(1); k++)
                {
                    sum = sum + (arr1[i, k] * arr2[k, j]);
                }
                res[i, j] = sum;
                //Console.Write("{0} ", res[i, j]);
            }
            //Console.WriteLine();
        }

        return res;
    }
}

