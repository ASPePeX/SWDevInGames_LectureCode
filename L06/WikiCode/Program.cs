using System;

namespace Wikipedia;

public interface IVisitor
{
    void Visit(Literal literal);  
    void Visit(Addition addition);
}

public interface IExpression
{
    public void Accept(IVisitor v);
   
    public double GetValue();
}

public class ExpressionPrintingVisitor : IVisitor
{
    public void Visit(Literal literal)
    {
        Console.WriteLine(literal.GetValue());
    }

    public void Visit(Addition addition)
    {
        double leftValue = addition.Left.GetValue();
        double rightValue = addition.Right.GetValue();
        var sum = addition.GetValue();
        Console.WriteLine("{0} + {1} = {2}", leftValue, rightValue, sum);
    }
 }



public class Literal : IExpression
{
    public Literal(double value)
    {
        this.Value = value;
    }

    public double Value { get; set; }

    public void Accept(IVisitor v)
    {
        v.Visit(this);
    }
 
    public double GetValue()
    {
        return Value;
    }
}

public class Addition : IExpression
{
    public Addition(IExpression left, IExpression right)
    {
        Left = left;
        Right = right;
    }

    public IExpression Left { get; set; }
    public IExpression Right { get; set; }

    public void Accept(IVisitor v)
    {
        Left.Accept(v);
        Right.Accept(v);
        v.Visit(this);
    }
  
    public double GetValue()
    {
        return Left.GetValue() + Right.GetValue();
    }
}

public static class Program
{
    public static void Main(string[] args)
    {
        // Emulate 1 + 2 + 3
        var e = new Addition( //2
                    new Addition( //1
                        new Literal(1),
                        new Literal(2)),
                    new Literal(3)
        );

        var printingVisitor = new ExpressionPrintingVisitor();
        e.Accept(printingVisitor);
    }
}