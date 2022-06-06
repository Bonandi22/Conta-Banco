using System;

namespace Jogodavelha1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String[,] Tabuleiro;
            Tabuleiro = new String[3, 3];
            int index = 1;
            int tentativas = 0;
            String jogada;
            String mudar = "X";
            

            Console.WriteLine("     Bem vindo     ");
            Console.WriteLine("-------------------");
            Console.WriteLine("   JOGO DA VELHA   ");
            Console.WriteLine("-------------------");
            Console.WriteLine("\n");

            //alimentando o tabuleiro
            for (int i = 0; i < Tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < Tabuleiro.GetLength(1); j++)
                {
                    Tabuleiro[i, j] = index.ToString();
                    index++;
                }
            }
            //imprimir o tabuleiro
            for (int i = 0; i < Tabuleiro.GetLength(0); i++)
            {
                for (int j = 0; j < Tabuleiro.GetLength(1); j++)
                {
                    Console.Write($"|{Tabuleiro[i, j]}|");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
            Console.WriteLine($"Voce quer jogar com [{mudar}] em qual posicao?");
            jogada = Convert.ToString(Console.ReadLine());
            Console.Clear();
            CheckWin();


            //inicio do jogo
            while (tentativas < 8)
            {
                Console.WriteLine("     Bem vindo     ");
                Console.WriteLine("-------------------");
                Console.WriteLine("   JOGO DA VELHA   ");
                Console.WriteLine("-------------------");
                Console.WriteLine("\n");

                //Alterar a posicao no tabuleiro
                for (int i = 0; i < Tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < Tabuleiro.GetLength(1); j++)
                    {
                        if (Tabuleiro[i, j] == jogada)
                        {
                            Tabuleiro[i, j] = mudar;
                        }
                    }
                }
                //imprimi tabuleiro                   
                for (int i = 0; i < Tabuleiro.GetLength(0); i++)
                {
                    for (int j = 0; j < Tabuleiro.GetLength(1); j++)
                    {
                        Console.Write($"|{Tabuleiro[i, j]}|");
                    }
                    Console.WriteLine();
                }





                //muda a posicao para o player 2 no tabuleiro
                if (mudar == "X")
                {
                    mudar = "0";
                }
                else
                {
                    mudar = "X";
                }

                //pergunta a posivao do palyer 2
                Console.WriteLine("\n");
                Console.WriteLine($"Voce quer jogar com [{mudar}] em qual posicao?");
                jogada = Convert.ToString(Console.ReadLine());
                tentativas++;
                Console.Clear();

                



            }
        }

        private static void CheckWin()
        {
            throw new NotImplementedException();
        }

        public static void CheckWin(string mudar, String[,] Tabuleiro)
        {

            // Condição de vitória nas Diagonais.
            if (Tabuleiro[0, 0] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[2, 2] ||
                    Tabuleiro[0, 2] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[2, 0])
            {
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nParabéns!!! O ganhador é [{mudar}].");
                
            }

            // Condição de vitória nas Linhas.
            if (Tabuleiro[0, 0] == Tabuleiro[0, 1] && Tabuleiro[0, 1] == Tabuleiro[0, 2] ||
                Tabuleiro[1, 0] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[1, 2] ||
                Tabuleiro[2, 0] == Tabuleiro[2, 1] && Tabuleiro[2, 1] == Tabuleiro[2, 2])
            {
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nParabéns!!! O ganhador é [{mudar}].");
                
               
            }

            // Condição de vitória nas Colunas.
            if (Tabuleiro[0, 0] == Tabuleiro[1, 0] && Tabuleiro[1, 0] == Tabuleiro[2, 0] ||
                Tabuleiro[0, 1] == Tabuleiro[1, 1] && Tabuleiro[1, 1] == Tabuleiro[2, 1] ||
                Tabuleiro[0, 2] == Tabuleiro[1, 2] && Tabuleiro[1, 2] == Tabuleiro[2, 2])
            {
                Console.WriteLine("\n--------------");
                Console.WriteLine("Fim de Jogo!!!");
                Console.WriteLine("--------------");
                Console.WriteLine($"\nParabéns!!! O ganhador é [{mudar}].");                
           
            }
            

        }
    }
}



