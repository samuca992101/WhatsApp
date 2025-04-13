using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Calculadora de Áreas ===");
        Console.WriteLine("1 - Círculo");
        Console.WriteLine("2 - Quadrado");
        Console.WriteLine("3 - Triângulo");
        Console.Write("Escolha uma opção: ");
        string opcao = Console.ReadLine();

        Forma formaEscolhida;

        switch (opcao)
        {
            case "1":
                Console.Write("Digite o raio do círculo: ");
                double raio = double.Parse(Console.ReadLine());
                formaEscolhida = new Circulo(raio);
                break;

            case "2":
                Console.Write("Digite o lado do quadrado: ");
                double lado = double.Parse(Console.ReadLine());
                formaEscolhida = new Quadrado(lado);
                break;

            case "3":
                Console.Write("Digite a base do triângulo: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Digite a altura do triângulo: ");
                double h = double.Parse(Console.ReadLine());
                formaEscolhida = new Triangulo(b, h);
                break;

            default:
                Console.WriteLine("Opção inválida.");
                return;
        }

        Console.WriteLine($"A área é: {formaEscolhida.CalcularArea():F2}");
    }
}
