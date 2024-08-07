namespace Exercicios;
public class Exercicio03
{
    public static void Rodar()
    {
        Console.Clear();
        Console.WriteLine("Digite o primeiro número:");
        var primeiroNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o segundo número:");
        var segundoNumero = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"A soma entre {primeiroNumero} e {segundoNumero} é {primeiroNumero + segundoNumero}");
        Console.WriteLine($"A subtração de {primeiroNumero} por {segundoNumero} é {primeiroNumero - segundoNumero}");
        Console.WriteLine($"A multiplicação de {primeiroNumero} por {segundoNumero} é {primeiroNumero * segundoNumero}");
        Console.WriteLine($"A divisão de {primeiroNumero} por {segundoNumero} é {(float)primeiroNumero / (float)segundoNumero}");
        Console.WriteLine($"A média entre {primeiroNumero} e {segundoNumero} é {(float)(primeiroNumero + segundoNumero) / 2}");

        Console.WriteLine("Pressione qualquer tecla para voltar");
        Console.ReadKey();
    }
}
