// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


class Program
{
    static void Main()
    {
        /* Pré-Requisitos do Sistema */
        //  Váriáveis e Atribuição de valor
        string nome;
        string jogoFavorito;
        byte idade;
        string plataforma;

        /* Entrada de dados */

        Console.Write("Qual é o seu nome? ");
        nome = Console.ReadLine() ?? "";

        Console.Write("Qual é o seu jogo favorito? ");
        jogoFavorito = Console.ReadLine() ?? "";

        Console.Write("Qual é a idade do Jogador ? ");
        idade = byte.Parse(Console.ReadLine() ?? "");

        Console.Write("Qual é a plataforma preferida: PC, PlayStation, Xbox ou outra? ");
        plataforma = Console.ReadLine() ?? "";

        Console.Write("");

        /* Processamento de dados */

        if (plataforma == "PC")
        {
            Console.WriteLine("Você joga no computador.");
        }
        else if (plataforma == "PlayStation")
        {
            Console.WriteLine("Você joga no console.");
        }
        else if (plataforma == "Xbox")
        {
            Console.WriteLine("Você joga no console.");
        }

        if (idade >= 18)
        {
            Console.WriteLine("Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Você é menor de idade.");
        };

        /* Saída de dados */

            Console.WriteLine($"{nome} tem {idade} anos e prefere jogar {jogoFavorito} no {plataforma}.");

        /* Fim do programa */

        Console.ReadKey();
    }
}