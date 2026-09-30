Pessoa p1 = new Pessoa();
p1.Nome = "carlos";

Pessoa p2 = p1;
p2.Nome = "ana";

Console.WriteLine(p1.Nome);

class Pessoa
{
    public string Nome { get; set; } = string.Empty;
}