using System;

class Produto
{
    private string nome;
    private string codigo;
    private decimal preco;
    private int quantidadeEstoque;

    public string Nome
    {
        get { return nome; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O nome é obrigatório.");
            }

            nome = value;
        }
    }

    public string Codigo
    {
        get { return codigo; }

        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O código é obrigatório.");
            }

            codigo = value;
        }
    }

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

    public int QuantidadeEstoque
    {
        get { return quantidadeEstoque; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("A quantidade não pode ser negativa.");
            }

            quantidadeEstoque = value;
        }
    }

    public bool EstoqueBaixo
    {
        get
        {
            return QuantidadeEstoque <= 5;
        }
    }

    public void AdicionarEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        QuantidadeEstoque += quantidade;
    }

    public void RemoverEstoque(int quantidade)
    {
        if (quantidade <= 0)
        {
            throw new ArgumentException("A quantidade deve ser maior que zero.");
        }

        if (quantidade > QuantidadeEstoque)
        {
            throw new ArgumentException("Não há estoque suficiente.");
        }

        QuantidadeEstoque -= quantidade;
    }
}

class Program
{
    static void Main()
    {
        Produto produto = new Produto();

        produto.Nome = "Teclado";
        produto.Codigo = "TEC001";
        produto.Preco = 150;

        produto.AdicionarEstoque(20);

        Console.WriteLine(produto.QuantidadeEstoque);

        produto.RemoverEstoque(10);

        Console.WriteLine(produto.QuantidadeEstoque);
        Console.WriteLine(produto.EstoqueBaixo);

    }
}