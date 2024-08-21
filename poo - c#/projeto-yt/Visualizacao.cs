using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_yt
{
    internal class Visualizacao
    {
        private Gafanhoto espectador;
        private Video filme;

        //Método Construtor
        public Visualizacao(Gafanhoto espectador, Video filme)
        {
            this.Espectador = espectador;
            this.Filme = filme;
            this.Espectador.TotAssistido = (this.Espectador.TotAssistido) + 1;
            this.Filme.Views = (this.Filme.Views) + 1;
        }

        //Método Get e Set
        public Video Filme { get => filme; set => filme = value; }
        internal Gafanhoto Espectador { get => espectador; set => espectador = value; }

        //Sobrescrevendo o método ToString()
        public override string ToString()
        {
            return $"Espectador {this.Espectador}, Filme: {this.Filme}";
        }

        //Métodos
        public void Avaliar()
        {
            this.Filme.Avaliacao = 5;
        }

        public void Avaliar(int nota)
        {
            this.Filme.Avaliacao = nota;
        }

        public void Avaliar(float porc)
        {
            int tot = 0;
            if(porc <= 20)
            {
                tot = 3;
            } else if(porc <= 50)
            {
                tot = 5;
            } else if(porc <= 90)
            {
                tot = 8;
            }
            else
            {
                tot = 10;
            }
            this.Filme.Avaliacao = tot;
        }
    }
}
