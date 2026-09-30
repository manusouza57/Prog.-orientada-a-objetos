using System;

class Elevador
{
    private int andarAtual;
    private int totalAndares;

    public Elevador(int totalAndares)
    {
        this.totalAndares = totalAndares;
        this.andarAtual = 0;
    }

    public void Subir()
    {
        if (andarAtual < totalAndares)
        {
            andarAtual++;
        }
    }

    public void Descer()
    {
        if (andarAtual > 0)
        {
            andarAtual--;
        }
    }

    public void ExibirAndar()
    {
        Console.WriteLine($"Andar atual: {andarAtual}");
    }
}

class Program
{
    static void Main()
    {
        Elevador e = new Elevador(10);
        e.Subir();
        e.Subir();
        e.ExibirAndar(); 
        e.Descer();
        e.ExibirAndar(); 
        e.Descer();
        e.Descer();
        e.ExibirAndar(); 

        
        Elevador e2 = new Elevador(3);
        e2.Descer();
        e2.ExibirAndar(); 
        e2.Subir();
        e2.Subir();
        e2.Subir();
        e2.Subir();
        e2.ExibirAndar();
    }
}