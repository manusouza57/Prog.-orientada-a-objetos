using System;
using System.Collections.Generic;

class Veiculo
{
    public string Placa;
    public string Modelo;
    public DateTime Entrada;
    public DateTime Saida;
    public int Horas;
    public decimal Valor;
}

class Program
{
    static List<Veiculo> vagas = new List<Veiculo>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nvagas ocupadas: " + vagas.Count + "/5");
            Console.Write("Digite 1 para Entrada, 2 para Saida ou 3 para Sair: ");
            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                if (vagas.Count >= 5)
                {
                    Console.WriteLine(" estacionamento ja esta lotado");
                    continue;
                }

                Console.Write("Placa: ");
                string placa = Console.ReadLine();

                if (placa == "")
                {
                    Console.WriteLine(" placa esta vazia");
                    continue;
                }

                Veiculo v = new Veiculo();
                v.Placa = placa;

                Console.Write("Modelo: ");
                v.Modelo = Console.ReadLine();

                Console.Write("Entrada (horario): ");
                v.Entrada = DateTime.Parse(Console.ReadLine());

                vagas.Add(v);
                Console.WriteLine("entrada registrada");
            }
            else if (opcao == "2")
            {
                Console.Write("Digite a placa para sair: ");
                string placaProcurada = Console.ReadLine();

                Veiculo carro = null;
                foreach (var v in vagas)
                {
                    if (v.Placa == placaProcurada)
                    {
                        carro = v;
                    }
                }

                if (carro == null)
                {
                    Console.WriteLine("Veiculo nao foi encontrado");
                    continue;
                }

                Console.Write("Saida (horario): ");
                carro.Saida = DateTime.Parse(Console.ReadLine());

                if (carro.Saida < carro.Entrada)
                {
                    Console.WriteLine("Saida menor que entrada");
                    continue;
                }

                TimeSpan tempo = carro.Saida - carro.Entrada;
                carro.Horas = (int)Math.Ceiling(tempo.TotalHours);

                if (carro.Horas < 1)
                {
                    carro.Horas = 1;
                }

                carro.Valor = carro.Horas * 10;

                Console.WriteLine("\nRECIBO");
                Console.WriteLine("Placa: " + carro.Placa);
                Console.WriteLine("Modelo: " + carro.Modelo);
                Console.WriteLine("Tempo: " + carro.Horas + " hora(s)");
                Console.WriteLine("Valor: R$ " + carro.Valor);

                vagas.Remove(carro);
                Console.WriteLine("Vaga liberada");
            }
            else if (opcao == "3")
            {
                break;
            }
        }
    }
}
