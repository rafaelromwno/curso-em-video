using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public abstract class Pessoa
    {
        //Atributos
        private string nome;
        private int idade;
        private char sexo;

        //Método Construtor
        public Pessoa(string nome, int idade, char sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
        }

        //Métodos Get e Set
        public string Nome { get => nome; set => nome = value; }
        public int Idade { get => idade; set => idade = value; }
        public char Sexo { get => sexo; set => sexo = value; }

        //Métodos
        public void fazerAniv()
        {
            idade++;
        }

        // Sobrescrevendo o método ToString
        public override string ToString()
        {
            return $"Nome: {nome}, Idade: {idade}, Sexo: {sexo}";
        }

    }
}
