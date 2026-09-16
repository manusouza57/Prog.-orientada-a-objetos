using System;

class Produto
{
    private decimal preco;

    public decimal Preco
    {
        get { return preco; }

        set
        {
            if (value < 0)
            {
                throw new ArgumentException("O preço não pode ser negativo.");
            }

            preco = value;
        }
    }

    private string nome;

    public string Nome
    {
        get { return nome; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome não pode ser vazio.");
            }

            nome = value;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        try
        {
            produto.Preco = 100;
            Console.WriteLine(produto.Preco);

            produto.Preco = 250;
            Console.WriteLine(produto.Preco);

            produto.Preco = -50;
            Console.WriteLine(produto.Preco);
        }
        catch (ArgumentException erro)
        {
            Console.WriteLine("Erro: " + erro.Message);
        }
    }
}