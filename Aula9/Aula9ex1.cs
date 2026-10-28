using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Digite o nome do produto: ");
            string nome = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(nome))
                throw new ArgumentException("O nome do produto não pode ficar em branco.");

            Console.Write("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine() ?? "");

            if (preco <= 0)
                throw new ArgumentException("O preço deve ser maior que zero.");

            Console.WriteLine($"Produto: {nome}");
            Console.WriteLine($"Preço: R$ {preco:F2}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite um preço válido.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
    }
}