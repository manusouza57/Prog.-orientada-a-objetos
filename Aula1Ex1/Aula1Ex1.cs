public class Pessoa
{
    public string Nome;
    public int Idade;
    public string Cargo;

    public void Apresentar()
    {
        Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos");
    }

    public void salario()
    {
        if (Cargo == "Gerente")
        {
            Console.WriteLine("Salario: 10.000,00");
        }
        else if (Cargo == "Desenvolvedor")
        {
            Console.WriteLine("Salario: 5.000,00");
        }
        else if (Cargo == "Estagiário")
        {
            Console.WriteLine("Salario: 100,00");
        }
    }
}

public class program
{
    public static void Main()
    {
        Pessoa p1 = new Pessoa();
        p1.Idade = 30;
        p1.Nome = "João";
        p1.Cargo = "Gerente";

        Pessoa p2 = new Pessoa();
        p2.Idade = 28;
        p2.Nome = "Carol";
        p2.Cargo = "Desenvolvedor";

        Pessoa p3 = new Pessoa();
        p3.Idade = 20;
        p3.Nome = "Mariana";
        p3.Cargo = "Estagiário";

        p1.Apresentar();
        p1.salario();

        p2.Apresentar();
        p2.salario();

        p3.Apresentar();
        p3.salario();
    }
}