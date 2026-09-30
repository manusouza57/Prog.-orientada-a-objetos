public class Fantasma
{
    public string Habilidade;
    public string Nick;
    public string Cor;

    public void GerarFantasma()
    {
        Console.WriteLine($"Nick: {Nick}");
        Console.WriteLine($"Habilidade: {Habilidade}");
        Console.WriteLine($"Cor: {Cor}");
    }

    public void Mover(string direcao)
    {
        Console.WriteLine($"{Nick} se moveu para {direcao}");
    }
}

public class Program
{
    public static void Main()
    {
        Fantasma fantasma1 = new Fantasma();

        fantasma1.Nick = "Blinky";
        fantasma1.Habilidade = "Perseguir";
        fantasma1.Cor = "Vermelho";

        fantasma1.GerarFantasma();
        fantasma1.Mover("Direita");
    }
}

