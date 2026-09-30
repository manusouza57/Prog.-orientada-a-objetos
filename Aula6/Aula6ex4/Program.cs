using System;

namespace Aula6ex4
{
    public interface IVoar
    {
        void Voar();
    }

    public interface INadar
    {
        void Nadar();
    }

    public class Pato : IVoar, INadar
    {
        public void Voar()
        {
            Console.WriteLine("O pato está voando");
        }

        public void Nadar()
        {
            Console.WriteLine("O pato está nadando");
        }
    }

    public class Aguia : IVoar
    {
        public void Voar()
        {
            Console.WriteLine("A águia está voando");
        }
    }

    public class Peixe : INadar
    {
        public void Nadar()
        {
            Console.WriteLine("O peixe está nadando");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Pato p = new Pato();
            p.Voar();
            p.Nadar();

            Aguia a = new Aguia();
            a.Voar();

            Peixe pe = new Peixe();
            pe.Nadar();
        }
    }
}