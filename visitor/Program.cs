namespace Visitor;

public class Program
{
    public static void Main(string[] args)
    {
        var i1 = new IntExpression(1); // object result
        var i2 = new IntExpression(2); // object result

        Expression sum = new SumExpression(i1, i2);
        Expression minus = new MinusExpression(i1, i2);

        EvaluateVisitor visitor = new EvaluateVisitor(); // injected class -- service to inject?

        var resultado = sum.Accept(visitor);
        Console.WriteLine($"Resultado da soma: {resultado}");

        var resultado2 = minus.Accept(visitor);
        Console.WriteLine($"Resultado da soma: {resultado2}");
    }
}

interface IVisitor
{
    object VisitSum(SumExpression e);
    object VisitMinus(MinusExpression e);
}

class EvaluateVisitor : IVisitor
{
    public object VisitMinus(MinusExpression e)
    {
        return (int)e.left.Accept(this) - (int)e.right.Accept(this);
    }

    public object VisitSum(SumExpression e)
    {
        return (int)e.left.Accept(this) + (int)e.right.Accept(this);
    }
}

abstract class Expression
{
    public abstract object Accept(IVisitor v);
}

class SumExpression : Expression
{
    public Expression left;
    public Expression right;

    public SumExpression(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override object Accept(IVisitor v)
    {
        return v.VisitSum(this);
    }
}

class MinusExpression : Expression
{
    public Expression left;
    public Expression right;

    public MinusExpression(Expression left, Expression right)
    {
        this.left = left;
        this.right = right;
    }

    public override object Accept(IVisitor v)
    {
        return v.VisitMinus(this);
    }
}

class IntExpression : Expression
{
    public int value;
    public IntExpression(int value)
    {
        this.value = value;
    }
    public override object Accept(IVisitor v)
    {
        return value;
    }
}