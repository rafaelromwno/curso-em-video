using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_yt
{
    internal abstract class Pessoa
    {
        //Atributos
        private string nome;
        private int idade;
        private string sexo;
        private float experiencia ;

        //Métodos Get e Set
        protected string Nome { get => nome; set => nome = value; }
        protected int Idade { get => idade; set => idade = value; }
        protected string Sexo { get => sexo; set => sexo = value; }
        protected float Experiencia { get => experiencia; set => experiencia = value; }

        //Método Construtor
        protected Pessoa(string nome, int idade, string sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
            this.Experiencia = 0;
        }

        //Método


        //Sobrevescrendo ToString()
        public override string ToString()
        {
            return $"Nome: {nome}, Idade: {idade}, Sexo: {sexo}, Experiência: {experiencia} anos";
        }
    }
}
