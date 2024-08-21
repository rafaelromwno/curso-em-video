using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public class Aluno : Pessoa
    {
        //Atributos
        private int matricula;
        private string curso;

        //chamada explícita ao construtor base
        public Aluno(string nome, int idade, char sexo, int matricula , string curso) : base(nome, idade, sexo)
        {
            this.Matricula = matricula;
            this.Curso = curso;
        }

        // Métodos Get e Set
        public int Matricula { get => matricula; set => matricula = value; }
        public string Curso { get => curso; set => curso = value; }

        //Métodos
        public void PagarMensalidade()
        {
            Console.Write("Pagando mensalidade!");
        }
    }
}
