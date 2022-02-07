using System;

class Program 
{
    public static void Main()
    {
        Retangulo x = new Retangulo();
        x.Base = 10;
        x.Altura = 20;

        Console.WriteLine(x.Base);
        Console.WriteLine(x.Altura);
        Console.WriteLine(x.Area);
        Console.WriteLine(x.Diagonal);
        Console.WriteLine(x);
    }
}

class Retangulo 
{
    private double b;
    private double h;

    public double Base
    {
        get { return b; }
        set { if (value > 0) b = value; }
    }

    public double Altura
    {
        get { return h; }
        set { if (value > 0) h = value; }
    }

    public double Area
    {
        get { return b * h; }
    }

    public double Diagonal
    {
        get { return Math.Sqrt(b * b + h * h); }
    }

    public override string ToString()
    {
        return $"Base = {b} - Altura = {h}";
    }
}
