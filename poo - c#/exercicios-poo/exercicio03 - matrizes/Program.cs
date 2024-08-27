namespace exercicio03___matrizes
    //Popular uma matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declarar as variáveis
            int[,] matriz = new int[3, 3];
            int valor;

            //Processamento
            for (int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 3; c++)
                {
                    Console.Write($"Digite um valor para a posição {l},{c} da matriz:");
                    valor = int.Parse(Console.ReadLine());
                    matriz[l, c] = valor;
                }
            }

            //Saída
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write($"{matriz[l,c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
