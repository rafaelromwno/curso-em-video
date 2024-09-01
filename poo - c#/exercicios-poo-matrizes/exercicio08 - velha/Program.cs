using System;

namespace exercicio08___velha
{
    internal class Program
    {
        static string[,] matriz = new string[3, 3]
        {
            { "1", "2", "3" },
            { "4", "5" ,"6" },
            { "7", "8", "9" }
        };
        static string simbolo;
        static bool jogadaValida;

        static void Main(string[] args)
        {
            int posicaoEscolhida;

            simbolo = "X";
            MostraVelha();

            do
            {
                do
                {
                    Console.WriteLine($"Vai jogar [{simbolo}] em qual posição? ");
                    posicaoEscolhida = int.Parse(Console.ReadLine());
                    jogadaValida = VerificarJogada(simbolo, posicaoEscolhida);
                    if (!jogadaValida)
                    {
                        Console.WriteLine("JOGADA INVÁLIDA!");
                    }
                } while (!jogadaValida);

                MudaJogador();
                Console.Clear();
                MostraVelha();
            } while (!TerminouVelha());

            Console.WriteLine("JOGO FINALIZADO!");
        }

        static void MostraVelha()
        {
            Console.WriteLine("+---+---+---+");
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"| {matriz[l, c]} ");
                }
                Console.WriteLine("|");
                Console.WriteLine("+---+---+---+");
            }
        }

        static void MudaJogador()
        {
            if(simbolo == "X")
            {
                simbolo = "O";
            }
            else
            {
                simbolo = "X";
            }
        }

        static bool VerificarJogada(string simbolo, int posicaoEscolhida)
        {
            bool valido = false;
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (matriz[l, c] == posicaoEscolhida.ToString())
                    {
                        matriz[l, c] = simbolo;
                        valido = true;
                        break;
                    }
                }
                if (valido) break;
            }
            return valido;
        }

        static bool TerminouVelha()
        {
            bool terminou = false;
            int posicaoVazia;

            // Jogos em linha
            for (int l = 0; l < 3; l++)
            {
                if (matriz[l, 0] == matriz[l, 1] && matriz[l, 1] == matriz[l, 2])
                {
                    terminou = true;
                    break;
                }
            }
            if (!terminou)
            {
                // Jogos em coluna
                for (int c = 0; c < 3; c++)
                {
                    if (matriz[0, c] == matriz[1, c] && matriz[1, c] == matriz[2, c])
                    {
                        terminou = true;
                        break;
                    }
                }
            }
            if (!terminou)
            {
                // Jogos em diagonal
                if (matriz[0, 0] == matriz[1, 1] && matriz[1, 1] == matriz[2, 2])
                {
                    terminou = true;
                }
                else if (matriz[0, 2] == matriz[1, 1] && matriz[1, 1] == matriz[2, 0])
                {
                    terminou = true;
                }
            }
            if (!terminou)
            {
                // Jogos em VELHA (empate)
                posicaoVazia = 0;
                for (int l = 0; l < 3; l++)
                {
                    for (int c = 0; c < 3; c++)
                    {
                        if (matriz[l, c] != "X" && matriz[l, c] != "O")
                        {
                            posicaoVazia++;
                        }
                    }
                }
                if (posicaoVazia == 0)
                {
                    terminou = true;
                }
            }

            // Retorna se o jogo acabou ou não
            return terminou;
        }
    }
}
