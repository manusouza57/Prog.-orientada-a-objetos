using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[3];
        double[] precos = new double[3];
        int[] quantidades = new int[3];
        double subtotal = 0;

        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Nome do produto:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine("Preco:");
            precos[i] = double.Parse(Console.ReadLine());

            Console.WriteLine("Quantidade:");
            quantidades[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < 3; i++)
        {
            double total = precos[i] * quantidades[i];
            subtotal = subtotal + total;

            Console.WriteLine(nomes[i] + " " +
                precos[i].ToString("C") + " " +
                quantidades[i].ToString("N0") + " " +
                total.ToString("C"));
        }

        double desconto = subtotal * 0.10;
        double totalFinal = subtotal - desconto;

        Console.WriteLine("Subtotal: " + subtotal.ToString("C"));
        Console.WriteLine("Desconto: " + desconto.ToString("C"));
        Console.WriteLine("Porcentagem: " + 0.10.ToString("P"));
        Console.WriteLine("Total final: " + totalFinal.ToString("C"));
    }
}