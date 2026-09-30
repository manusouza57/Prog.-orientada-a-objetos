public class ContaBancaria
{
    public string Titular;
    public int NumeroConta;
    public double Saldo;

    public void Depositar(double valor)
    {
        Saldo = Saldo + valor;
        Console.WriteLine($"Depósito de R$ {valor:F2} realizado.");
    }

    public void Sacar(double valor)
    {
        if (valor <= Saldo)
        {
            Saldo = Saldo - valor;
            Console.WriteLine($"Saque de R$ {valor:F2} realizado.");
        }
        else
        {
            Console.WriteLine("Saldo insuficiente.");
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Número da conta: {NumeroConta}");
        Console.WriteLine($"Saldo: R$ {Saldo:F2}");
    }
}

public class Program
{
    public static void Main()
    {
        ContaBancaria conta1 = new ContaBancaria();
        conta1.Titular = "João";
        conta1.NumeroConta = 1234;

        ContaBancaria conta2 = new ContaBancaria();
        conta2.Titular = "Maria";
        conta2.NumeroConta = 5678;

        conta1.Depositar(1000);
        conta1.Sacar(300);
        conta1.ExibirSaldo();

        Console.WriteLine();

        conta2.Depositar(500);
        conta2.Sacar(700);
        conta2.ExibirSaldo();
    }
}