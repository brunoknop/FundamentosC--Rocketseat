using System.Text.RegularExpressions;

namespace Exercicios;
public class Exercicio05
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine("Digite uma placa de veículo:");
        var placa = Console.ReadLine();

        if (ValidarPlaca(placa))
            Console.WriteLine($"Placa {placa} válida");
        else
            Console.WriteLine($"Placa {placa} inválida");

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }

    private static bool ValidarPlaca(string placa)
    {
        var padrao = @"^[A-Z]{3}\d{4}$";
        var regex = new Regex(padrao);

        return regex.IsMatch(placa);
    }
}
