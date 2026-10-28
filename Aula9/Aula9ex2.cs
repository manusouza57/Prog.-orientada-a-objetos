using System;

class Program
{
    static float ConverterTemperatura(string entrada)
    {
        if (!float.TryParse(entrada, out float temperatura))
            throw new FormatException("Temperatura inválida.");

        return temperatura;
    }

    static void Main()
    {
        float temperatura;
        bool valido = false;

        do
        {
            try
            {
                Console.Write("Digite a temperatura em Celsius: ");
                string entrada = Console.ReadLine() ?? "";

                temperatura = ConverterTemperatura(entrada);
                valido = true;

                Console.WriteLine($"Temperatura: {temperatura} °C");
            }
            catch (FormatException)
            {
                Console.WriteLine("Valor inválido. Digite novamente.");
            }
        } while (!valido);
    }
}