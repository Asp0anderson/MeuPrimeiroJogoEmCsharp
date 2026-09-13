// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MeuPrimeiroJogoV5.Program2;

namespace MeuPrimeiroJogoV5
{

    public class Program
    {
        static void Main()
        {

            /* Pré-Requisitos, declarando variáveis e atribuindo valores*/

            int numeroMenor = 1;
            int numeroMaior = 20;
            Random sorteador = new Random();
            int numeroSecreto = sorteador.Next(numeroMenor, numeroMaior + 1);
            int quantidadeTentativas = 0;
            bool acertou = false;


            /* Métodos */
            // 1 - MostrarApresentacao
            // Mostra o título e as instruções do jogo.
            MostrarApresentacao(numeroMenor, numeroMaior);

            /* Processamento das informações, a execução das regras do jogo.*/
            // Continua repetindo enquanto o jogador não acertar.
            while (!acertou)
            {
                // Uso de Métodos dentro while.
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

    }

}
