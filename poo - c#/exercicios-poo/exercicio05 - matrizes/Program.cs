namespace exercicio05___matrizes
    //Matriz identidade de terceira ordem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            int[,] matriz = new int[3,3];

            for(int l = 0; l < 3; l++)
            {
                for(int c = 0; c < 3; c++)
                {
                    if(l == c)
                    {
                        matriz[l,c] = 1;
                    }
                    else
                    {
                        matriz[l,c] = 0;
                    }
                    Console.Write($"{matriz[l, c]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
