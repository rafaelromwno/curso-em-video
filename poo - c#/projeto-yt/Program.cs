namespace projeto_yt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Video[] v = new Video[3];

            v[0] = new Video("Aula 1 de POO");
            v[1] = new Video("Aula 12 de PHP");
            v[2] = new Video("Aula 2 de HTML5");

            //v[0].ToString();

            Gafanhoto[] g = new Gafanhoto[2];

            g[0] = new Gafanhoto("Jubileu", 22, "M", "juba");
            g[1] = new Gafanhoto("Creuza", 19, "F", "creuzita");

            //Console.Write(g[0].ToString());

            Visualizacao[] visu = new Visualizacao[2];

            visu[0] = new Visualizacao(g[0], v[2]); //Jubileu assiste HTML
            visu[0].Avaliar();
            Console.Write($"\n{visu[0].ToString()}");

            visu[1] = new Visualizacao(g[0], v[1]); //Jubileu assiste PHP
            visu[1].Avaliar(87.0f);
            Console.Write($"\n{visu[1].ToString()}");

        }
    }
}
