class Conta
{
    public decimal Saldo { get; private set; }

    public void Depositar(decimal valor)
    {
        if (valor <= 0)
        {
            throw new ArgumentException("O depósito deve ser maior que zero.");
        }

        Saldo += valor;
    }
}