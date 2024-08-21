using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Livro : Publicacao
    {
        //Atributos
        private string titulo;
        private string autor;
        private int totPaginas;
        private int pagAtual = 0;
        private bool aberto = false;
        private Pessoa leitor;


        //Métodos
        public void detalhes()
        {
            Console.WriteLine($"\nLivro titulo = {Titulo}, \nAutor = {Autor}, \nTotal de Páginas = {totPaginas}, \nPágina Atual = {pagAtual}, \nEstá aberto = {Aberto} e \nNome do Leitor = {this.Leitor?.Nome ?? "Nenhum leitor atribuído!"}, " +
                $"Idade do Leitor = {this.Leitor?.Idade}, Sexo do Leitor = {this.Leitor?.Sexo}");
        }

        //Método Construtor

        public Livro(string titulo, string autor, int totPaginas, Pessoa leitor)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.TotPaginas = totPaginas;
            this.Leitor = leitor;
        }


        //Método Get (acessor) e Método Set (modificador ou mutante)

        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int TotPaginas { get => totPaginas; set => totPaginas = value; }
        public int PagAtual { get => pagAtual; set => pagAtual = value; }
        public bool Aberto { get => aberto; set => aberto = value; }
        internal Pessoa Leitor { get => leitor; set => leitor = value; }

        //Implementando Métodos 

        public void abrir()
        {
            this.aberto = true;
        }

        public void fechar()
        {
            this.aberto = false;
        }

        public void folhear(int p)
        {
            if((this.pagAtual + p) > totPaginas)
            {
                Console.Write($"O livro não tem {this.pagAtual + p} páginas!");
            }
            else
            {
                this.pagAtual = p;
            }
        }

        public void avançarPag()
        {
            this.pagAtual++;
        }

        public void voltarPag()
        {
            this.pagAtual--;
        }


    }
}
