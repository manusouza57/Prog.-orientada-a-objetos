using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Nome do evento:");
        string nome = Console.ReadLine();

        Console.WriteLine("Data do evento (dd/MM/yyyy):");
        DateTime data = DateTime.ParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy",
            CultureInfo.InvariantCulture
        );

        Console.WriteLine("Valor do ingresso:");
        double valor = double.Parse(Console.ReadLine());

        Console.WriteLine("Categoria VIP ou Comum:");
        string categoria = Console.ReadLine().ToUpper();

        if (categoria.Contains("VIP"))
        {
            categoria = "VIP";
        }
        else if (categoria.Contains("COMUM"))
        {
            categoria = "Comum";
        }
        else
        {
            Console.WriteLine("Categoria invalida");
            return;
        }

        int dias = (data.Date - DateTime.Today).Days;
        double desconto = 0;

        if (categoria == "VIP")
        {
            desconto = valor * 0.10;
        }

        double total = Math.Round(valor - desconto, 2);

        string ingresso = string.Format(
            "Evento: {0}\nCategoria: {1}\nData: {2:dd/MM/yyyy}\nDias restantes: {3}\nValor: {4:C}\nDesconto: {5:C}\nTotal: {6:C}",
            nome, categoria, data, dias, valor, desconto, total
        );

        Console.WriteLine(ingresso);
    }
}