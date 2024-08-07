namespace Exercicios;
public class Exercicio02
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine("Digite seu nome:");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite seu sobrenome:");
        var sobrenome = Console.ReadLine();

        Console.WriteLine($"{nome} {sobrenome}");

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }
}
