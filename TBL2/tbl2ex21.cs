using System;
using System.Collections.Generic;

abstract class Funcionario
{
    public string Nome { get; set; }

    public void RegistrarPonto()
    {
        Console.WriteLine($"{Nome}: ponto registrado.");
    }

    public abstract decimal CalcularSalario();
}

class Gerente : Funcionario
{
    public decimal SalarioBase { get; set; } = 8000;
    public decimal Bonus { get; set; } = 2000;

    public override decimal CalcularSalario()
    {
        return SalarioBase + Bonus;
    }
}

class Programador : Funcionario
{
    public decimal ValorHora { get; set; } = 50;
    public int HorasTrabalhadas { get; set; } = 160;

    public override decimal CalcularSalario()
    {
        return ValorHora * HorasTrabalhadas;
    }
}

class Program
{
    static void Main()
    {
        Gerente gerente = new Gerente { Nome = "Ana" };
        Programador programador = new Programador { Nome = "Bruno" };

        Console.WriteLine($"Salário do gerente {gerente.Nome}: {gerente.CalcularSalario():C}");
        Console.WriteLine($"Salário do programador {programador.Nome}: {programador.CalcularSalario():C}");

        // Desafio adicional
        Console.WriteLine("\n--- Lista de funcionários ---");
        List<Funcionario> funcionarios = new List<Funcionario>();
        funcionarios.Add(gerente);
        funcionarios.Add(programador);

        foreach (Funcionario funcionario in funcionarios)
        {
            funcionario.RegistrarPonto();
            Console.WriteLine($"{funcionario.Nome} recebe {funcionario.CalcularSalario():C}");
        }
    }
}