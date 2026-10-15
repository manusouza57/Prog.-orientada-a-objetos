using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o capital:");
        double capital = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a taxa mensal:");
        double taxa = double.Parse(Console.ReadLine()) / 100;

        Console.WriteLine("Digite os meses:");
        int meses = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a meta:");
        double meta = double.Parse(Console.ReadLine());

        double montante = capital * Math.Pow(1 + taxa, meses);
        double lucro = montante - capital;

        Console.WriteLine("Montante: " + montante);
        Console.WriteLine("Lucro: " + Math.Round(lucro, 2));

        if (lucro > meta)
            Console.WriteLine("Superou a meta");
        else
            Console.WriteLine("Não superou a meta");
    }
}