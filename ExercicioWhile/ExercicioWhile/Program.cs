using System;
using System.Globalization;

namespace ExercicioWhile {
    class Program {
        static void Main(string[] args) {

            //Primeira Questão
            int senha = 0;

            Console.Write("Digite a senha: ");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002) {
                Console.WriteLine("Senha incorreta");

                Console.Write("Digite a senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso permitido");

            //Segunda Questão
            int x = 0;
            int y = 0;

            Console.Write("Digite às coordenadas(x/y): ");
            string coordenada = Console.ReadLine();

            string[] vet = coordenada.ToString().Split(' ');

            x = int.Parse(vet[0]);
            y = int.Parse(vet[1]);

            if (x > 0 && y > 0) {
                Console.WriteLine("Primeiro Quadrante");
            }
            else if (x < 0 && y > 0) {
                Console.WriteLine("Segundo Quadrante");
            }
            else if (x < 0 && y < 0) {
                Console.WriteLine("Terceiro Quadrante");
            }
            else if (x == 0 || y == 0) {
                Console.WriteLine(" ");
            }
            else {
                Console.WriteLine("Quarto Quadrante");
            }


            while (x != 0 && y != 0) {
                Console.Write("Digite às coordenadas(x/y): ");
                coordenada = Console.ReadLine();

                vet = coordenada.ToString().Split(' ');

                x = int.Parse(vet[0]);
                y = int.Parse(vet[1]);

                if (x > 0 && y > 0) {
                    Console.WriteLine("Primeiro Quadrante");
                }
                else if (x < 0 && y > 0) {
                    Console.WriteLine("Segundo Quadrante");
                }
                else if (x < 0 && y < 0) {
                    Console.WriteLine("Terceiro Quadrante");
                }
                else if (x == 0 || y == 0) {
                    Console.WriteLine(" ");
                }
                else {
                    Console.WriteLine("Quarto Quadrante");
                }
            }

            //Terceira Questão
            int entrada = 0, alcool = 0, gasolina = 0, diesel = 0, cont = 0;

            while (cont < 4 && entrada != 4) {
                Console.Write("Digite o código: ");
                entrada = int.Parse(Console.ReadLine());

                if (entrada == 1) {
                    alcool++;
                }
                else if (entrada == 2) {
                    gasolina++;
                }
                else if (entrada == 3) {
                    diesel++;
                }

                if (entrada >= 5) {
                    Console.WriteLine("Código Inválido");
                }
                else {
                    cont++;
                }
            }

            Console.WriteLine("\nMUITO OBRIGADO!");
            Console.Write($"Alcool: {alcool}");
            Console.Write($"\nGasolina: {gasolina}");
            Console.Write($"\nDiesel: {diesel}");
        } 
    }
}