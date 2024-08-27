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

            while (true)
            {

                //JOGADOR 0
                //DIAGONAIS
                if (matriz[0, 0] == "O" && matriz[1, 1] == "O" && matriz[2, 2] == "O")
                {
                    Console.WriteLine($"BELA DIAGONAL! O JOGADOR O VENCEU!!");
                    break;
                }
                else if (matriz[0, 2] == "O" && matriz[1, 1] == "O" && matriz[2, 0] == "O")
                {
                    Console.WriteLine($"BELA DIAGONAL! O JOGADOR O VENCEU!!");
                    break;
                }
                //HORIZONTAIS
                else if (matriz[0, 0] == "O" && matriz[0, 1] == "O" && matriz[0, 2] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }
                else if (matriz[1, 0] == "O" && matriz[1, 1] == "O" && matriz[1, 2] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }
                else if (matriz[2, 0] == "O" && matriz[2, 1] == "O" && matriz[2, 2] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }
                //VERTICAIS
                else if (matriz[0, 0] == "O" && matriz[1, 0] == "O" && matriz[2, 0] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }
                else if (matriz[0, 1] == "O" && matriz[1, 1] == "O" && matriz[2, 1] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }
                else if (matriz[0, 2] == "O" && matriz[1, 2] == "O" && matriz[2, 2] == "O")
                {
                    Console.WriteLine($"O JOGADOR O VENCEU!!");
                    break;
                }

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

                //Jogador X - Verifica qual posição ele gostaria de jogar
                // e verifica se a posição que ele escolheu está disponível!
                Console.Write("Vai jogar [X] em qual posição?");
                int jogadorX = int.Parse(Console.ReadLine());

                if (jogadorX == 1)
                {
                    if (matriz[0, 0] == "1")
                    {
                        matriz[0, 0] = "X";
                    }
                }
                else if (jogadorX == 2)
                {
                    if (matriz[0, 1] == "2")
                    {
                        matriz[0, 1] = "X";
                    }
                }
                else if (jogadorX == 3)
                {
                    if (matriz[0, 2] == "3")
                    {
                        matriz[0, 2] = "X";
                    }
                }
                else if (jogadorX == 4)
                {
                    if (matriz[1, 0] == "4")
                    {
                        matriz[1, 0] = "X";
                    }
                }
                else if (jogadorX == 5)
                {
                    if (matriz[1, 1] == "5")
                    {
                        matriz[1, 1] = "X";
                    }
                }
                else if (jogadorX == 6)
                {
                    if (matriz[1, 2] == "6")
                    {
                        matriz[1, 2] = "X";
                    }
                }
                else if (jogadorX == 7)
                {
                    if (matriz[2, 0] == "7")
                    {
                        matriz[2, 0] = "X";
                    }
                }
                else if (jogadorX == 8)
                {
                    if (matriz[2, 1] == "8")
                    {
                        matriz[2, 1] = "X";
                    }
                }
                else if (jogadorX == 9)
                {
                    if (matriz[2, 2] == "9")
                    {
                        matriz[2, 2] = "X";
                    }
                }
                else
                {
                    Console.Write("POSICAO INVALIDA!");
                }

                //MOSTRAR AÇÃO - X
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

                //VERIFICAR SE O JOGADOR X GANHOU
                //DIAGONAIS
                if (matriz[0, 0] == "X" && matriz[1, 1] == "X" && matriz[2, 2] == "X")
                {
                    Console.WriteLine($"BELA DIAGONAL! O JOGADOR X VENCEU!!");
                    break;
                }
                else if (matriz[0, 2] == "X" && matriz[1, 1] == "X" && matriz[2, 0] == "X")
                {
                    Console.WriteLine($"BELA DIAGONAL! O JOGADOR X VENCEU!!");
                    break;
                }
                //HORIZONTAIS
                else if (matriz[0, 0] == "X" && matriz[0, 1] == "X" && matriz[0, 2] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }
                else if (matriz[1, 0] == "X" && matriz[1, 1] == "X" && matriz[1, 2] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }
                else if (matriz[2, 0] == "X" && matriz[2, 1] == "X" && matriz[2, 2] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }
                //VERTICAIS
                else if (matriz[0, 0] == "X" && matriz[1, 0] == "X" && matriz[2, 0] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }
                else if (matriz[0, 1] == "X" && matriz[1, 1] == "X" && matriz[2, 1] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }
                else if (matriz[0, 2] == "X" && matriz[1, 2] == "X" && matriz[2, 2] == "X")
                {
                    Console.WriteLine($"O JOGADOR X VENCEU!!");
                    break;
                }

                //Jogador O - Verifica qual posição ele gostaria de jogar
                // e verifica se a posição que ele escolheu está disponível!
                Console.Write("Vai jogar [O] em qual posição?");
                int jogadorO = int.Parse(Console.ReadLine());

                if (jogadorO == 1)
                {
                    if (matriz[0, 0] == "1")
                    {
                        matriz[0, 0] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 2)
                {
                    if (matriz[0, 1] == "2")
                    {
                        matriz[0, 1] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 3)
                {
                    if (matriz[0, 2] == "3")
                    {
                        matriz[0, 2] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 4)
                {
                    if (matriz[1, 0] == "4")
                    {
                        matriz[1, 0] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 5)
                {
                    if (matriz[1, 1] == "5")
                    {
                        matriz[1, 1] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 6)
                {
                    if (matriz[1, 1] == "6")
                    {
                        matriz[1, 2] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 7)
                {
                    if (matriz[2, 0] == "7")
                    {
                        matriz[2, 0] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 8)
                {
                    if (matriz[2, 1] == "8")
                    {
                        matriz[2, 1] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                else if (jogadorO == 9)
                {
                    if (matriz[2, 2] == "9")
                    {
                        matriz[2, 2] = "O";
                    }
                    else
                    {
                        Console.Write("POSICAO INVALIDA!");
                    }
                }
                         
            }
        }
    }
}