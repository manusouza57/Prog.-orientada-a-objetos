
using System;

namespace Aula6ex1
{
    class Veiculo
    {
        public string marca;
        public string modelo;

        public void ExibirVeiculo()
        {
            Console.WriteLine($"Marca: {marca}, Modelo: {modelo}");
        }
    }

    class Carro : Veiculo
    {
        public int numPortas;

        public void ExibirCarro()
        {
            ExibirVeiculo();
            Console.WriteLine($"Número de Portas: {numPortas}");
        }
    }

    class Moto : Veiculo
    {
        public int numRodas;
        public bool possuiBagageiro;

        public void ExibirMoto()
        {
            ExibirVeiculo();
            Console.WriteLine($"Número de Rodas: {numRodas}, Possui Bagageiro: {possuiBagageiro}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Carro c = new Carro();
            c.marca = "Toyota";
            c.modelo = "Corolla";
            c.numPortas = 4;

            Console.WriteLine("CARRO");
            c.ExibirCarro();

            Console.WriteLine();

            Moto m = new Moto();
            m.marca = "Honda";
            m.modelo = "CG 160";
            m.numRodas = 2;
            m.possuiBagageiro = true;

            Console.WriteLine("MOTO");
            m.ExibirMoto();
        }
    }
}