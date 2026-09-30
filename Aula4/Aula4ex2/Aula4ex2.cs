using System;

class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }
    public string Email { get; set; }
}

class Program
{
    static void Main()
    {
        Pessoa pessoa = new Pessoa();

        pessoa.Nome = "João";
        pessoa.Idade = 20;
        pessoa.Email = "joao@email.com";

        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Idade);
        Console.WriteLine(pessoa.Email);

        pessoa.Idade = 21;

        Console.WriteLine("Depois da alteração:");
        Console.WriteLine(pessoa.Nome);
        Console.WriteLine(pessoa.Idade);
        Console.WriteLine(pessoa.Email);
    }
}