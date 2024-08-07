namespace Exercicios;
public class Exercicio01
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine("Olá! Qual é o seu nome?");
        var nome = Console.ReadLine();
        Console.WriteLine($"Olá, {nome}! Seja muito bem-vindo!");

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }
}