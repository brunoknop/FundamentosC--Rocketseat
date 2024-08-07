namespace Exercicios;
public class Exercicio04
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine("Digite a palavra:");
        var palavra = Console.ReadLine();

        Console.WriteLine($"A palavra tem {palavra.Length}");

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }
}
