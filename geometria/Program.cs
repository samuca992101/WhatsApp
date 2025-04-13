using System;

class Program
{
    static void Main(string[] args)
    {
        string opcao;

        do
        {
            Console.WriteLine("=== Calculadora de Áreas ===");
            Console.WriteLine("1 - Círculo");
            Console.WriteLine("2 - Quadrado");
            Console.WriteLine("3 - Triângulo");
            Console.WriteLine("4 - SAIR");
            Console.Write("Escolha uma opção: ");
            opcao = Console.ReadLine();
            
            Forma formaEscolhida = null;

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

                case "4":
                    Console.WriteLine("Encerrando...");
                    break;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }

            if (formaEscolhida != null)
            {
                Console.WriteLine($"A área é: {formaEscolhida.CalcularArea():F2}\n");
            }

        } while (opcao != "4");
    }
}
