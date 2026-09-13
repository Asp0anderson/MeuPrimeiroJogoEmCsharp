using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeuPrimeiroJogoV5.Program;

namespace MeuPrimeiroJogoV5
{
    public static class Program2
    {
        /* Métodos */
        public static void MostrarApresentacao(int numeroMenor, int numeroMaior)
        {
            // Exibe o título do jogo.
            Console.WriteLine("=== Jogo de Adivinhação ===");

            // Exibe o intervalo de números possíveis.
            Console.WriteLine($"Tente descobrir o número secreto entre {numeroMenor} e {numeroMaior}.");

            // Exibe uma instrução para o jogador.
            Console.WriteLine("Boa sorte!");
        }

        public static int LerTentativa(int numeroMenor, int numeroMaior)
        {
            // Declara uma variável para guardar a tentativa.
            int tentativa;

            // Repete até o jogador digitar um valor válido.
            while (true)
            {
                // Solicita uma tentativa ao jogador.
                Console.WriteLine();
                Console.Write($"Digite um número entre {numeroMenor} e {numeroMaior}: ");

                // Lê o texto digitado pelo jogador.
                string entrada = Console.ReadLine() ?? "";

                // Tenta converter o texto para número.
                bool entradaValida = int.TryParse(entrada, out tentativa);

                // Verifica se o texto era um número dentro do intervalo.
                if (entradaValida &&
                    tentativa >= numeroMenor &&
                    tentativa <= numeroMaior)
                {
                    // Retorna a tentativa válida para o método Main.
                    return tentativa;
                }

                // Mostra uma mensagem quando a entrada é inválida.
                Console.WriteLine(
                    $"Digite um número inteiro entre {numeroMenor} e {numeroMaior}."
                );
            }
        }

        public static bool VerificarTentativa(int tentativa, int numeroSecreto)
        {
            // Verifica se a tentativa é igual ao número secreto.
            if (tentativa == numeroSecreto)
            {
                // Informa que o jogador acertou.
                Console.WriteLine("Parabéns! Você acertou!");

                // Retorna true para encerrar o laço principal.
                return true;
            }

            // Verifica se o número secreto é maior que a tentativa.
            if (tentativa < numeroSecreto)
            {
                // Dá uma dica ao jogador.
                Console.WriteLine("Você errou! O número secreto é maior.");
            }
            else
            {
                // Dá uma dica quando a tentativa foi maior.
                Console.WriteLine("Você errou! O número secreto é menor.");
            }

            // Retorna false para continuar o jogo.
            return false;
        }

        public static void MostrarFinal(int quantidadeTentativas, int numeroSecreto)
        {
            // Exibe a quantidade de tentativas usadas.
            Console.WriteLine();
            Console.WriteLine($"Você acertou em {quantidadeTentativas} tentativa(s).");

            // Exibe o número secreto.
            Console.WriteLine($"O número secreto era {numeroSecreto}.");

            // Exibe a mensagem de encerramento.
            Console.WriteLine();
            Console.WriteLine("Fim de jogo!");
            Console.ReadKey();
        }
    }

}
