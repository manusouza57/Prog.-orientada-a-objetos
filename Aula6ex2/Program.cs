using System;

namespace Aula6ex2
{
    class Pessoa
    {
        public string nome;
    }

    class Casa
    {
        public Pessoa morador;

        public void ExibirMorador()
        {
            Console.WriteLine($"Morador da casa: {morador.nome}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pessoa p = new Pessoa();
            p.nome = "Carlos";

            Casa c = new Casa();
            c.morador = p;

            c.ExibirMorador();
        }
    }
}