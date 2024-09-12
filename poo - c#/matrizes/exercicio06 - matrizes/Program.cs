namespace exercicio06___matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            double[,] matriz = new double[4,4];
            double diagonalPrincipal = 0;
            double produtoSegunda = 1;
            double maiorValor = double.NegativeInfinity;


            for (int l = 0;l < 4; l++)
            {
                for(int c = 0; c < 4; c++)
                {
                    Console.Write($"Digite um valor inteiro para a posição {l},{c}: ");
                    matriz[l,c] = double.Parse(Console.ReadLine());

                    if(l == c)
                    {
                        diagonalPrincipal += matriz[l, c];
                    }

                    if(l == 1)
                    {
                        produtoSegunda *= matriz[l,c];
                    }
                }
            }

            for (int l = 0; l < 4; l++)
            {
                if (matriz[l, 2] > maiorValor)
                {
                    maiorValor = matriz[l, 2];
                }
            }

            //Saída de dados
            for (int l = 0; l < 4; l++)
            {
                for (int c = 0; c < 4; c++)
                {
                    Console.Write($"{matriz[l,c]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine($"A soma da diagonal principal é: {diagonalPrincipal}");
            Console.WriteLine($"O produto da 2ª linha é: {produtoSegunda}");
            Console.WriteLine($"O maior valor da 3ª coluna é: {maiorValor}");
        }
    }
}
