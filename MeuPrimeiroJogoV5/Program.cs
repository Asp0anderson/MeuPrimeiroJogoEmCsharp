// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main()
    {
        // Define o menor número possível.
        int numeroMenor = 1;

        // Define o maior número possível.
        int numeroMaior = 20;

        // Cria um objeto responsável por sortear números.
        Random sorteador = new Random();

        // O segundo valor de Next não é incluído.
        // Por isso usamos numeroMaior + 1 para permitir o número 20.
        int numeroSecreto = sorteador.Next(numeroMenor, numeroMaior + 1);

        // Guarda a quantidade de tentativas do jogador.
        int quantidadeTentativas = 0;

        // Mostra o título e as instruções do jogo.
        MostrarApresentacao(numeroMenor, numeroMaior);

        // Começa o laço principal do jogo.
        bool acertou = false;

        // Continua repetindo enquanto o jogador não acertar.
        while (!acertou)
        {
            // Lê uma tentativa válida do jogador.
            int tentativa = LerTentativa(numeroMenor, numeroMaior);

            // Aumenta o contador de tentativas.
            quantidadeTentativas++;

            // Verifica a tentativa e guarda o resultado.
            acertou = VerificarTentativa(tentativa, numeroSecreto);
        }

        // Mostra a mensagem final.
        MostrarFinal(quantidadeTentativas, numeroSecreto);
    }

    static void MostrarApresentacao(int numeroMenor, int numeroMaior)
    {
        // Exibe o título do jogo.
        Console.WriteLine("=== Jogo de Adivinhação ===");

        // Exibe o intervalo de números possíveis.
        Console.WriteLine(
            $"Tente descobrir o número secreto entre {numeroMenor} e {numeroMaior}."
        );

        // Exibe uma instrução para o jogador.
        Console.WriteLine("Boa sorte!");
    }

    static int LerTentativa(int numeroMenor, int numeroMaior)
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

    static bool VerificarTentativa(int tentativa, int numeroSecreto)
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

    static void MostrarFinal(int quantidadeTentativas, int numeroSecreto)
    {
        // Exibe a quantidade de tentativas usadas.
        Console.WriteLine();
        Console.WriteLine(
            $"Você acertou em {quantidadeTentativas} tentativa(s)."
        );

        // Exibe o número secreto.
        Console.WriteLine($"O número secreto era {numeroSecreto}.");

        // Exibe a mensagem de encerramento.
        Console.WriteLine("Fim de jogo!");
    }
}
