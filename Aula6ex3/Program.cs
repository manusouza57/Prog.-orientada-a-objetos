using System;

namespace Aula6ex3
{
    public interface IVeiculo
    {
        void Mover();
    }

    public class Carro : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("O carro está se movendo");
        }
    }

    public class Bicicleta : IVeiculo
    {
        public void Mover()
        {
            Console.WriteLine("A bicicleta está se movendo");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            IVeiculo c = new Carro();
            IVeiculo b = new Bicicleta();

            c.Mover();
            b.Mover();
        }
    }
}