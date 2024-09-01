namespace exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Visitante v1 = new Visitante("João", 22, 'm');
            
            Console.WriteLine($"\n{v1.ToString()}");

            Aluno a1 = new Aluno("Cláudio", 22, 'm', 01, "DSM");

            Console.WriteLine($"\n{a1.Matricula}");

            Bolsista b1 = new Bolsista("Rafael", 18, 'm', 900);

            Console.WriteLine($"\n{b1.ToString()}");

        }
    }
}
