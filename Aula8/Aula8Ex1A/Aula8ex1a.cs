using System;

class Program
{
    static void Main()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine("Digite um número:");
            double n = double.Parse(Console.ReadLine());

            Console.WriteLine(n);
            Console.WriteLine(Math.Round(n));
            Console.WriteLine(Math.Floor(n));
            Console.WriteLine(Math.Ceiling(n));
            Console.WriteLine(Math.Truncate(n));
        }
    }
}