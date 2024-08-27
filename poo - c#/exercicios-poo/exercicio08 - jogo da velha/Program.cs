namespace exercicio08___jogo_da_velha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            string[,] matriz = new string[3, 3]
            {
                { "1", "2", "3" },
                { "4", "5", "6" },
                { "7", "8", "9" }
            };

            //Lendo a Matriz
            Console.WriteLine("+--+--+");
            for (int l = 0; l < 3; l++)
            {
                Console.Write("|");
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"{matriz[l, c]}|");
                }
                Console.WriteLine("\n+--+--+");
            }

            //Jogo da velha
            Console.Write("Vai jogar [X] em qual posição?");
            int jogadorX = int.Parse(Console.ReadLine());

            if(jogadorX == 1)
            {
                matriz[1, 1] = "X";
            } 
            else if(jogadorX == 2)
            {
                matriz[1, 2] = "X";
            }
            else if (jogadorX == 3)
            {
                matriz[1, 3] = "X";
            }
            else if (jogadorX == 4)
            {
                matriz[2, 1] = "X";
            }
            else if (jogadorX == 5)
            {
                matriz[2, 2] = "X";
            }
            else if (jogadorX == 6)
            {
                matriz[2, 3] = "X";
            }
            else if (jogadorX == 7)
            {
                matriz[3, 1] = "X";
            }
            else if (jogadorX == 8)
            {
                matriz[3, 2] = "X";
            }
            else if (jogadorX == 9)
            {
                matriz[3, 3] = "X";
            } 
            else if(jogadorX == "O")
            {
                Console.Write("POSICAO INVALIDA!");
            }

            Console.Write("Vai jogar [O] em qual posição?");
            int jogadorO = int.Parse(Console.ReadLine());

        }
    }
}