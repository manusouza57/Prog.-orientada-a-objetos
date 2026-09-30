public class Produto
{
    public string Nome;
    public double Preco;
    public int Quantidade;

    public void ExibirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Preço: R$ {Preco:F2}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }

    public double CalcularValorTotal()
    {
        return Preco * Quantidade;
    }
}

public class Program
{
    public static void Main()
    {
        Produto produto1 = new Produto();
        produto1.Nome = "Arroz";
        produto1.Preco = 25.00;
        produto1.Quantidade = 2;

        Produto produto2 = new Produto();
        produto2.Nome = "Feijão";
        produto2.Preco = 8.00;
        produto2.Quantidade = 3;

        Produto produto3 = new Produto();
        produto3.Nome = "Macarrão";
        produto3.Preco = 5.00;
        produto3.Quantidade = 4;

        produto1.ExibirDados();
        Console.WriteLine($"Valor total: R$ {produto1.CalcularValorTotal():F2}");
        Console.WriteLine();

        produto2.ExibirDados();
        Console.WriteLine($"Valor total: R$ {produto2.CalcularValorTotal():F2}");
        Console.WriteLine();

        produto3.ExibirDados();
        Console.WriteLine($"Valor total: R$ {produto3.CalcularValorTotal():F2}");
    }
}

