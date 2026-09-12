// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System; // Permite usar Console e Random.

class Program // Declara a classe principal do programa.
{
    static void Main() // Define o ponto de início do programa.
    {
        Random sorteador = new Random(); // Cria um objeto capaz de sortear números.

        int numeroSecreto = sorteador.Next(1, 11); // Sorteia um número entre 1 e 10.
        int tentativa = 0; // Guarda a tentativa atual do jogador.
        int quantidadeTentativas = 0; // Conta quantas tentativas foram feitas.
        bool acertou = false; // Indica se o jogador acertou o número.

        Console.WriteLine("=== Jogo de Adivinhação ==="); // Exibe o título do jogo.
        Console.WriteLine("Tente descobrir o número secreto entre 1 e 10."); // Explica o objetivo.

        while (!acertou) // Continua repetindo enquanto o jogador não acertar.
        {
            Console.Write("Digite sua tentativa: "); // Solicita um número ao jogador.

            tentativa = int.Parse(Console.ReadLine() ?? "0"); // Lê e converte a resposta para int.

            quantidadeTentativas++; // Aumenta a quantidade de tentativas em 1.

            if (tentativa == numeroSecreto) // Verifica se a tentativa é igual ao número secreto.
            {
                acertou = true; // Informa ao programa que o jogador acertou.

                Console.WriteLine(
                    $"Parabéns! Você acertou em {quantidadeTentativas} tentativa(s)."
                ); // Exibe a mensagem de vitória.
            }
            else if (tentativa < numeroSecreto) // Verifica se a tentativa foi menor que o número secreto.
            {
                Console.WriteLine("O número secreto é maior."); // Dá uma dica ao jogador.
            }
            else // Executa quando a tentativa foi maior que o número secreto.
            {
                Console.WriteLine("O número secreto é menor."); // Dá outra dica ao jogador.
            }
        }

        Console.WriteLine("Fim do jogo!"); // Informa que o jogo terminou.

        Console.ReadKey(); // Aguarda uma tecla antes de fechar a janela.
    }
}
