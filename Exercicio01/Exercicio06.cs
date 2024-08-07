namespace Exercicios;
public class Exercicio06
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.Date.ToShortDateString());
        Console.WriteLine(DateTime.Now.TimeOfDay);
        Console.WriteLine(DateTime.Now.Date.ToLongDateString());

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }
}
