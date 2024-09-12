namespace exercicio04___matrizes
    //Popular uma matriz e mostrar os valores pares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int[,] matriz = new int[3, 2];

            //Processamento de dados
            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 2; c++)
                {
                    Console.Write($"Digite um valor inteiro para a posição {l},{c} da matriz:");
                    int valor = int.Parse(Console.ReadLine());
                    matriz[l, c] = valor;
                }
            }

            //Saída de Dados
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 2; c++)
                {
                    if (matriz[l,c] % 2 == 0)
                    {
                        Console.Write($"({matriz[l, c]}) ");
                    }
                    else
                    {
                        Console.Write($"{matriz[l, c]} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
