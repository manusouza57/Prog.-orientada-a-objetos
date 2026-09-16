class ContaBancaria
{
    private decimal saldo;

    
    public decimal Saldo
    {
        get { return saldo; }
        private set { saldo = value; }
    }

  
    public void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            saldo += valor;
        }
    }

}