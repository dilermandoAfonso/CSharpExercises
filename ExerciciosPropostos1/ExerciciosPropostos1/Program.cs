using System;
using System.Globalization;

namespace ExerciciosPropostos1 {
    class Program {
        static void Main(string[] args) {

            //Primeira Questão
            Console.Write("Valor 1: ");
            int primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Valor 2: ");
            int segundoValor = int.Parse(Console.ReadLine());

            Console.WriteLine(primeiroValor + segundoValor);
            Console.WriteLine("");

            //Segunda Questão
            double pi = 3.14159;

            Console.Write("Digite o valor do raio: ");
            double valorRaio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = pi * valorRaio * valorRaio;

            Console.WriteLine(area.ToString("F4"));
            Console.WriteLine("");

            //Terceira Questão
            Console.Write("Valor de A: ");
            int dado1 = int.Parse(Console.ReadLine());

            Console.Write("Valor de B: ");
            int dado2 = int.Parse(Console.ReadLine());

            Console.Write("Valor de C: ");
            int dado3 = int.Parse(Console.ReadLine());

            Console.Write("Valor de D: ");
            int dado4 = int.Parse(Console.ReadLine());

            int diferenca = (dado1 * dado2) - (dado3 * dado4);
            Console.WriteLine(diferenca);
            Console.WriteLine("");

            //Quarta Questão
            Console.Write("Digite o número do funcionário: ");
            double num = double.Parse(Console.ReadLine());

            Console.Write("Número de horas trabalhadas: ");
            double horasTrab = double.Parse(Console.ReadLine());

            Console.Write("Valor recebido por hora: ");
            double valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double valorTotal = valorHora * horasTrab;

            Console.WriteLine($"SALARY = {valorTotal:C}");
            Console.WriteLine("");

            //Quinta Questão
            Console.Write("Peça 1 (Código/Qtd/Valor): ");
            string peca1 = Console.ReadLine();

            Console.Write("Peça 2 (Código/Qtd/Valor): ");
            string peca2 = Console.ReadLine();

            string[] vet1 = peca1.ToString().Split(' ');
            string[] vet2 = peca2.ToString().Split(' ');

            int codigo1 = int.Parse(vet1[0]);
            int qtd1 = int.Parse(vet1[1]);
            double valor1 = double.Parse(vet1[2], CultureInfo.InvariantCulture);

            int codigo2 = int.Parse(vet2[0]);
            int qtd2 = int.Parse(vet2[1]);
            double valor2 = double.Parse(vet2[2], CultureInfo.InvariantCulture);

            double resultado = valor1 * qtd1 + valor2 * qtd2;
            Console.WriteLine(resultado.ToString("C"));
            Console.WriteLine("");

            //Sexta Questão
            double A, B, C;

            Console.Write("Valores de A, B e C: ");
            string valor = Console.ReadLine();
            string[] valores = valor.ToString().Split(' ');

            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double triangulo = (A * C) / 2;
            double circulo = 3.14159 * Math.Pow(C, 2);
            double trapezio = (A + B) * C / 2;
            double quadrado = Math.Pow(B, 2);
            double retangulo = A * B;

            Console.WriteLine(triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine(retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}