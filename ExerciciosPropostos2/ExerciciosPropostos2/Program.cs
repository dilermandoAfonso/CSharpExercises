using System;
using System.Globalization;

namespace ExerciciosPropostos2 {
    class Program {
        static void Main(string[] args) {

            //Primeira questão
            Console.Write("Digite o valor: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero < 0) {
                Console.WriteLine("O valor é negativo");
            }
            else if (numero == 0) {
                Console.WriteLine("O valor é neutro");
            }
            else {
                Console.WriteLine("O valor é positivo");
            }

            //Segunda questão
            Console.Write("\nDigite o valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor2 % 2 == 0) {
                Console.WriteLine("O número é par");
            }
            else {
                Console.WriteLine("O número é ímpar");
            }

            //Terceira questão
            Console.Write("\nDigite os valores: ");
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);
            int B = int.Parse(vet[1]);

            if (A % B == 0 || B % A == 0) {
                Console.WriteLine("São múltiplos");
            }
            else {
                Console.WriteLine("Não são múltiplos");
            }


            //Quarta questão 
            int horaInicial, horaFinal, duracao;

            Console.Write("\nDigite a hora(Inicial/Final): ");
            string[] horas = Console.ReadLine().Split(' ');
            
            horaInicial = int.Parse(horas[0]);
            horaFinal = int.Parse(horas[1]);

            if (horaInicial < horaFinal) {
                Console.WriteLine("Duração do jogo: " + (horaFinal - horaInicial) + "hrs");
            }
            else {
                Console.WriteLine("Duração do jogo: " + (24 - horaInicial + horaFinal) + "hrs");
            }

            //Quinta questão
            Console.Write("\nDigite o código do produto/quantidade: ");
            string[] valores = Console.ReadLine().Split(' ');
            
            int codigo = int.Parse(valores[0]);
            int qtd = int.Parse(valores[1]);

            double valor;
            if (codigo == 1) {
                valor = 4.00 * qtd;
                Console.WriteLine(valor.ToString("C"));
            }
            else if (codigo == 2) {
                valor = 4.50 * qtd;
                Console.WriteLine(valor.ToString("C"));
            }
            else if (codigo == 3) {
                valor = 5.00 * qtd;
                Console.WriteLine(valor.ToString("C"));
            }
            else if (codigo == 4) {
                valor = 2.00 * qtd;
                Console.WriteLine(valor.ToString("C"));
            }
            else if (codigo == 5) {
                valor = 1.50 * qtd;
                Console.WriteLine(valor.ToString("C"));
            }
            else {
                Console.WriteLine("Número inválido");
            }

            //Sexta questão
            Console.Write("\nDigite o valor: ");
            double num = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (num < 0.0 || num > 100.0) {
                Console.WriteLine("Fora do intervalo");
            }
            else if (num <= 25.0) {
                Console.WriteLine("Intervalo: (0,25)");
            }
            else if (num <= 50.0) {
                Console.WriteLine("Intervalo: (25,50)");
            }
            else if (num <= 75.0) {
                Console.WriteLine("Intervalo: (50,75)");
            }
            else {
                Console.WriteLine("Intervalo: (75, 100)");
            }

            //Sétima questão
            Console.Write("\nDigite os valores (x/y): ");
            string[] valores2 = Console.ReadLine().Split(' ');

            double x = double.Parse(valores2[0], CultureInfo.InvariantCulture);
            double y = double.Parse(valores2[1], CultureInfo.InvariantCulture);

            if (x > 0.0 && y > 0.0) {
                Console.WriteLine("Q1");
            } 
            else if (x < 0.0 && y < 0.0) {
                Console.WriteLine("Q3");
            }
            else if (x < 0.0 && y > 0.0) {
                Console.WriteLine("Q2");
            }
            else if (x > 0.0 && y < 0.0) {
                Console.WriteLine("Q4");
            }
            else {
                Console.WriteLine("Origem");
            }

            //Oitava questão
            Console.Write("Digite o salário: ");
            double rombus = Double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (rombus <= 2000.00) {
                rombus = 0.0;
            }
            else if (rombus <= 3000.00) {
                rombus = (rombus - 2000.00) * 0.08;
            }
            else if (rombus <= 4500.00) {
                rombus = (rombus - 3000.00) * 0.18 + 1000.00 * 0.08;
            }
            else {
                rombus = (rombus - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            if (rombus > 0) {
                Console.WriteLine(rombus.ToString("C"));
            }
            else {
                Console.WriteLine("Isento");
            }
        }
    }
}