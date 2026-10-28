using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite um número inteiro: ");
            int numero = int.Parse(Console.ReadLine() ?? "");

            Console.WriteLine($"Número digitado: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Valor inválido. Por favor, digite um número inteiro.");
        }
    }
}