// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        /* Pré-Requisitos do Sistema */
        //  Váriáveis e Atribuição de valor

        Random sorteador = new Random();

        int numeroMenor = 10;
        int numeroMaior = 20;

        int numeroSecreto = sorteador.Next(numeroMenor, numeroMaior); // Sorteia um número entre o valor da variável numeroMenor e a variável numeroMaior..
        int tentativa = 0; // Guarda a tentativa atual do jogador.
        int quantidadeTentativas = 0; // Conta quantas tentativas foram feitas.
        bool acertou = false; // Indica se o jogador acertou o número.

        /* Apresentação */

        Console.WriteLine("=== Jogo de Adivinhação ==="); // Exibe o título do jogo.
        Console.WriteLine($"Tente descobrir o número secreto entre {numeroMenor} e {numeroMaior}."); // Explica o objetivo.
        Console.WriteLine("Pressione a tecla ENTER para continuar.");
        Console.ReadKey();

        /* Entrada e Processamento de dados */

        while (!acertou)
        {
            Console.WriteLine();
            Console.WriteLine("Digite sua tentativa: ");

            tentativa = int.Parse(Console.ReadLine() ?? "0");

            quantidadeTentativas++; // Aumenta a quantidade de tentativas em 1.

            if (tentativa == numeroSecreto)
            {
                acertou = true;
                Console.WriteLine();
                Console.WriteLine($"Parabéns! Você acertou em {quantidadeTentativas} tentativa(s).");
                Console.WriteLine($"O número secreto é {numeroSecreto} .");
            }
            else if (tentativa < numeroSecreto)
            {
                Console.WriteLine("O número secreto é maior.");
            }
            else
            {
                Console.WriteLine("O número secreto é menor.");
            }
        }

        /* Saída de dados */

        Console.WriteLine();
        Console.WriteLine("Fim de Jogo");
        Console.WriteLine("Pressione a tecla ENTER para encerrar.");

        /* Fim do programa */

        Console.ReadKey();
    }
}