using System;

class ContaBancaria
{
    public string Titular { get; private set; }

    public decimal Saldo { get; private set; }

    public ContaBancaria(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do depósito deve ser maior que zero.");
        }

        Saldo += valor;
    }

    public void Sacar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O valor do saque deve ser maior que zero.");
        }

        if (valor > Saldo)
        {
            throw new ArgumentException("Saldo insuficiente.");
        }

        Saldo -= valor;
    }
}

class Program
{
    static void Main()
    {
        ContaBancaria conta = new ContaBancaria("Carlos");

        conta.Depositar(1000);
        conta.Sacar(250);

        Console.WriteLine(conta.Saldo);
    }
}