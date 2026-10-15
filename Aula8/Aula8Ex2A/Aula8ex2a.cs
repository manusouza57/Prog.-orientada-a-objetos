using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite uma frase separada por virgulas:");
        string frase = Console.ReadLine();

        frase = frase.Trim();
        Console.WriteLine(frase);

        string[] palavras = frase.Split(',');

        foreach (string p in palavras)
        {
            Console.WriteLine(p);
        }

        Console.WriteLine("Digite a palavra que quer trocar:");
        string palavra = Console.ReadLine();

        Console.WriteLine("Digite a nova palavra:");
        string nova = Console.ReadLine();

        frase = frase.Replace(palavra, nova);
        Console.WriteLine(frase);

        Console.WriteLine("Digite uma palavra para verificar o inicio:");
        string inicio = Console.ReadLine();
        Console.WriteLine(frase.StartsWith(inicio));

        Console.WriteLine("Digite uma palavra para verificar o final:");
        string fim = Console.ReadLine();
        Console.WriteLine(frase.Trim().EndsWith(fim));
    }
}