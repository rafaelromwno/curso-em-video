namespace exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] p = new Pessoa[2];
            Livro[] l = new Livro[3];

            p[0] = new Pessoa("Pedro", 22, 'M');
            p[1] = new Pessoa("Maria", 20, 'F');

            l[0] = new Livro("Aprendendo C#", "Jose da Silva", 300, p[0]);
            l[1] = new Livro("POO para iniciantes", "Pedro Paulo", 200, p[1]);
            l[2] = new Livro("Java avançado","Maria Candido", 800, p[0] );


            l[0].abrir();
            l[0].folhear(599);

            l[0].detalhes();

        }
    }
}
