using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Digite o CPF:");
        string cpf = Console.ReadLine();

        cpf = cpf.Trim();
        cpf = cpf.Replace(".", "");
        cpf = cpf.Replace("-", "");
        cpf = cpf.Replace(" ", "");

        if (cpf.Length == 11 && char.IsDigit(cpf[0]))
        {
            cpf = cpf.Substring(0, 3) + "." +
                  cpf.Substring(3, 3) + "." +
                  cpf.Substring(6, 3) + "-" +
                  cpf.Substring(9, 2);

            Console.WriteLine(cpf);
        }
        else
        {
            Console.WriteLine("CPF invalido");
        }
    }
}