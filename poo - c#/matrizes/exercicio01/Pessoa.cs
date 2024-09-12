using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio01
{
    internal class Pessoa
    {
        //Atributos
        private string nome;
        private int idade;
        private char sexo;

        //Métodos
        public void fazerAniver()
        {
            this.idade++;
        }

        //Método Construtor
       public Pessoa(string nome, int idade, char sexo)
        {
            this.nome = nome;
            this.idade = idade;
            this.sexo = sexo;
        }

        //Método Get (acessor) e Método Set (modificador ou mutante)

        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }

    }
}
