using System;
using System.Collections.Generic;

class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}

class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento com Cartão de Crédito: validando limite e autorizando a compra.");
    }
}

class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento com Boleto Bancário: gerando boleto e aguardando compensação.");
    }
}

class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento com Pix: transferência instantânea confirmada.");
    }
}

class Program
{
    static void Main()
    {
        List<Pagamento> pagamentos = new List<Pagamento>();

        pagamentos.Add(new Pix());
        pagamentos.Add(new CartaoCredito());
        pagamentos.Add(new BoletoBancario());

        foreach (Pagamento pagamento in pagamentos)
        {
            pagamento.ProcessarPagamento();
        }
    }
}
