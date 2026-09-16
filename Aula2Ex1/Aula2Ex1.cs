using System;

class Produto
{
    private string nome;
    private decimal preco;

    public Produto(string nome, decimal preco)
    {
        this.nome = nome;
        if (preco < 0)
        {
            Console.WriteLine("Preço inválido. Definido como 0.");
            this.preco = 0;
        }
        else
        {
            this.preco = preco;
        }
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Produto: {nome} | Preço: {preco:C}");
    }

    public void AlterarPreco(decimal novoPreco)
    {
        if (novoPreco < 0)
        {
            Console.WriteLine("Erro: o preço não pode ser negativo.");
        }
        else
        {
            preco = novoPreco;
        }
    }
}

class Program
{
    static void Main()
    {
        Produto p = new Produto("Celular", 1500);
        p.ExibirDetalhes();
        p.AlterarPreco(-200); 
        p.AlterarPreco(1200);
        p.ExibirDetalhes();
    }
}