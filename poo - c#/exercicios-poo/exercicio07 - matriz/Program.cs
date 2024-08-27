namespace exercicio07___matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int[,] matriz = new int[4, 4];

            //Populando a matriz
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"Digite um valor inteiro para inserir na posição {l},{c} da matriz: ");
                    matriz[l,c] = int.Parse(Console.ReadLine());
                }
            }

            for(; ;)
            {
                //MENU
                Console.WriteLine($"MENU DE OPCOES \n ====================");
                Console.WriteLine($"[1] Mostrar a matriz");
                Console.WriteLine($"[2] Diagonal Principal");
                Console.WriteLine($"[3] Triangulo Superior");
                Console.WriteLine($"[4] Triangulo Inferior");
                Console.WriteLine($"[5] Sair");
                Console.Write($"===== OPCAO: ");
                int usuario = int.Parse(Console.ReadLine());

                //Saída de dados
                if (usuario == 1) //Mostrar a matriz
                {

                    for (int l = 0; l < 4; l++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            Console.Write($"{matriz[l, c]} ");
                        }
                        Console.WriteLine();
                    }

                }
                else if (usuario == 2) //Diagonal Principal
                {

                    for (int l = 0; l < 4; l++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            if (l == c)
                            {
                                Console.Write($"{matriz[l, c]} ");
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                }
                else if (usuario == 3) //Triangulo Superior
                {

                    for (int l = 0; l < 4; l++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            if (l < c)
                            {
                                Console.Write($"{matriz[l, c]} ");
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }

                }
                else if (usuario == 4) //Triangulo Inferior
                {

                    for (int l = 0; l < 4; l++)
                    {
                        for (int c = 0; c < 4; c++)
                        {
                            if (l > c)
                            {
                                Console.Write($"{matriz[l, c]} ");
                            }
                            Console.Write(" ");
                        }
                        Console.WriteLine();
                    }
                }
                else if (usuario == 5)
                {
                    break;
                }
            } 
        }
    }
}
