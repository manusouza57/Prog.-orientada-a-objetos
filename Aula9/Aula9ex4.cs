using System;

class IdadeInvalidaException : Exception
{
    public IdadeInvalidaException(string mensagem) : base(mensagem)
    {
    }
}

class Program
{
    static void VerificarIdade(int idade)
    {
        if (idade < 18)
            throw new IdadeInvalidaException("Idade mínima para acesso é 18 anos.");

        Console.WriteLine("Acesso permitido.");
    }

    static void Main()
    {
        try
        {
            Console.Write("Digite a idade: ");
            int idade = int.Parse(Console.ReadLine() ?? "");

            VerificarIdade(idade);
        }
        catch (IdadeInvalidaException ex)
        {
            Console.WriteLine($"Erro: {ex.Message}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Digite uma idade válida.");
        }
    }
}