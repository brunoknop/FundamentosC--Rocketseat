namespace Exercicios;

class Program
{
    static void Main()
    {
        var sair = false;

        while (!sair)
        {
            Console.WriteLine("Digite de 1 a 6 para selecionar o exercício que deseja executar.");
            Console.WriteLine("Ou digite 0 para sair.");
            var exercicio = Console.ReadLine();

            switch (exercicio)
            {
                case "1":
                    Exercicio01.Rodar();
                    break;
                case "2":
                    Exercicio02.Rodar();
                    break;
                case "3":
                    Exercicio03.Rodar();
                    break;
                case "4":
                    Exercicio04.Rodar();
                    break;
                case "5":
                    Exercicio05.Rodar();
                    break;
                case "6":
                    Exercicio06.Rodar();
                    break;
                case "0":
                    sair = true;
                    break;
            }

            Console.Clear();
        }

    }
}