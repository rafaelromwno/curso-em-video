using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_yt
{
    public class Video : AcoesVideo
    {
        //Atributos
        private string titulo;
        private int avaliacao;
        private int views;
        private int curtidas;
        private bool reproduzindo;

        //Método Construtor
        public Video(string titulo)
        {
            this.Titulo = titulo;
            this.Avaliacao = 1;
            this.Views = 0;
            this.Curtidas = 0;
            this.Reproduzindo = false;
        }

        //Métodos Get e Set
        public string Titulo { get => titulo; set => titulo = value; }
        public int Avaliacao { get => avaliacao; set => avaliacao = value; }
        public int Views { get => views; set => views = value; }
        public int Curtidas { get => curtidas; set => curtidas = value; }
        public bool Reproduzindo { get => reproduzindo; set => reproduzindo = value; }

        //Implementar Classe (Métodos que estão na interface)
        public void like()
        {
            this.curtidas++;
        }

        public void pause()
        {
            this.reproduzindo = false;
        }

        public void play()
        {
            this.reproduzindo = true;
        }

        //Sobrevescrendo ToString()
        public override string ToString()
        {
            return $"Titulo é {this.titulo}, avaliacao é {this.avaliacao}, views é {this.views}, curtidas é {this.curtidas} e reproduzindo é {this.reproduzindo}";
        }

            
    }
}
