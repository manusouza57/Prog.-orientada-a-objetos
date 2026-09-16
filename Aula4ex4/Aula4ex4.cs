using System;

class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }

    public double Area
    {
        get
        {
            return Largura * Altura;
        }
    }
}

class Program
{
    static void Main()
    {
        Retangulo retangulo = new Retangulo();

        retangulo.Largura = 10;
        retangulo.Altura = 5;

        Console.WriteLine(retangulo.Area);

        retangulo.Largura = 20;

        Console.WriteLine(retangulo.Area);
    }
}