Console.Write("digite um numero: ");
string? entrada = Console.ReadLine();

if (int.TryParse(entrada, out int numero))
{
    Console.WriteLine($"numero digitado: {numero}");
}
else
{
    Console.WriteLine("entrada negada.. digite um número inteiro");
}