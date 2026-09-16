using System;

class Carro
{
    private string modelo;
    private int velocidadeAtual;

    public Carro(string modelo)
    {
        this.modelo = modelo;
        this.velocidadeAtual = 0;
    }

    public void Acelerar(int valor)
    {
        velocidadeAtual += valor;
    }

    public void Frear(int valor)
    {
        velocidadeAtual -= valor;
        if (velocidadeAtual < 0)
        {
            velocidadeAtual = 0;
        }
    }

    public void ExibirVelocidade()
    {
        Console.WriteLine($"Velocidade atual: {velocidadeAtual}");
    }
}

class Program
{
    static void Main()
    {
        Carro c = new Carro("Ferrari");
        c.Acelerar(50);
        c.ExibirVelocidade(); 
        c.Frear(30);
        c.ExibirVelocidade(); 
        c.Frear(50);
        c.ExibirVelocidade(); 
    }
}