using System;

// QUESTÃO 1: Cópia de Tipos de Valor
int primeiro = 10;
int segundo = primeiro;
segundo = 20;

Console.WriteLine($"Q1: Primeiro={primeiro}, Segundo={segundo}");

// QUESTÃO 2: Cópia de Tipos de Referência
Pessoa p1 = new Pessoa();
p1.Nome = "Carlos";

Pessoa p2 = p1;
p2.Nome = "Ana";

Console.WriteLine($"Q2: Nome={p1.Nome}");

// QUESTÃO 3: Conversão Explícita (Casting)
double valorDouble = 9.87;
int valorInt = (int)valorDouble;

Console.WriteLine($"Q3: Double={valorDouble}, Int={valorInt}");

// QUESTÃO 4: Conversão Segura com TryParse
Console.Write("Q4 - Digite um número: ");
string entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    Console.WriteLine($"Número digitado: {numero}");
}
else
{
    Console.WriteLine("Entrada inválida.");
}

class Pessoa
{
    public string Nome;
}
