using System;
using System.Globalization;
using System.Numerics;

namespace ExercicioFor {
    class Program {
        static void Main(string[] args) {

            //Primeira Questão
            //Console.Write("Digite o valor de X: ");
            //int x = int.Parse(Console.ReadLine());

            //for (int a = x;a >= 1 && x >=1; a-=1) {
            //    int resto = x % 2;

            //    if (resto != 0) {
            //        Console.WriteLine(x);
            //        x -= 1;
            //    }
            //    x -= 1;
            //}

            //Segunda Questão
            //int fora = 0;
            //int dentro = 0;

            //Console.Write("Digite a quantidade de valores que serão lidos: ");
            //int n = int.Parse(Console.ReadLine());


            //for (int b = 1; b < n; b++) {
            //    Console.Write($"Digite o #{b} valor de X: ");
            //    int y = int.Parse(Console.ReadLine());

            //    if (y < 10 || y > 20) {
            //        fora++;
            //    }
            //    else {
            //        dentro++;
            //    }
            //}

            //Console.WriteLine($"Fora: {fora}");
            //Console.WriteLine($"Dentro: {dentro}");

            //Terceira Questão
            //Console.Write("Digite o número de valores: ");
            //int vezes = int.Parse(Console.ReadLine());

            //double[] elementoPeso = new double[vezes];
            //double[] valores = new double[vezes];
            //double[] pesos = { 2, 3, 5 };

            //for (int i = 0; i < vezes; i++) {
            //    double val = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //    valores[i] = val;

            //    double peso = valores[i] * pesos[i];
            //    elementoPeso[i] = peso;
            //}

            //double total = (elementoPeso[0] + elementoPeso[1] + elementoPeso[2]) / (pesos[0] + pesos[1] + pesos[2]);

            //Console.Write("Resultado: ");
            //Console.WriteLine(total.ToString("F1", CultureInfo.InvariantCulture));

            //Quarta Questão
            //Console.Write("Digite a quantidade de números: ");
            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i < num; i++) {
            //    Console.Write("Entrada: ");
            //    string[] nums = Console.ReadLine().Split(' ');

            //    double num1 = int.Parse(nums[0]);
            //    double num2 = int.Parse(nums[1]);

            //    if (num2 == 0) {
            //        Console.WriteLine("Divisão impossível");
            //    }
            //    else {
            //        double divisao = num1 / num2;
            //        Console.WriteLine(divisao.ToString("F1", CultureInfo.InvariantCulture));
            //    }
            //}

            //Quinta Questão

            //Console.Write("Entrada: ");
            //int valor = int.Parse(Console.ReadLine());
            //int numero = 0;
            //int resultado = 0;

            //for (int i = 1; i < valor; i++) {
            //    if (i <= 1){
            //        numero = valor * (valor - i);
            //    }
            //    else {
            //        numero *= (valor - i);
            //    } 
            //}

            //if (numero == 0) {
            //    numero = 1;
            //}

            //Console.WriteLine(numero);

            //Sexta Questão
            //Console.Write("Insira o valor: ");
            //int numeroInt = int.Parse(Console.ReadLine());
            //int divisor = 1;

            //for (int i = 0; i < numeroInt; i++) {
            //    if (numeroInt % divisor == 0) {
            //        Console.WriteLine(divisor);
            //        divisor++;
            //    }
            //    else {
            //        divisor++;
            //    }
            //}

            ////Sétima Questão 
            //Console.Write("Insira a quantidade, somente com número positivo: ");
            //int numeroPositivo = int.Parse(Console.ReadLine());

            //if (numeroPositivo <= 0) {
            //    Console.WriteLine("O número digitado não é positivo");
            //}
            //else {
            //    for (int linha = 1; linha <= numeroPositivo; linha++) {
            //        int quadrado = linha * linha;
            //        int cubo = linha * linha * linha;
            //        Console.WriteLine($"{linha} {quadrado} {cubo}");
            //    }
            //}
        }
    }
}
 
