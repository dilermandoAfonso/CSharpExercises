using System;
using System.Globalization;

namespace ExercicioFixacao2
{
    internal class Program {
        static void Main(string[] args) {
            
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço do produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha)");
            string[] vet = Console.ReadLine().Split(' ');
            string nome2 = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);

            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine(nome2);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}