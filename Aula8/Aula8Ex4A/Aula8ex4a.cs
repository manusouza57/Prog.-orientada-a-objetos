using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Data e hora (dd/MM/yyyy HH:mm):");
        DateTime data = DateTime.ParseExact(
            Console.ReadLine(),
            "dd/MM/yyyy HH:mm",
            CultureInfo.InvariantCulture
        );

        int dias = (data.Date - DateTime.Today).Days;
        string dia = data.ToString("dddd", new CultureInfo("pt-BR"));

        string mensagem = string.Format(
            "Ola, {0}!\nSeu compromisso sera em {1} dias, na {2}.\nData: {3:dd/MM/yyyy} as {3:HH:mm}",
            nome, dias, dia, data
        );

        Console.WriteLine(mensagem);
    }
}
