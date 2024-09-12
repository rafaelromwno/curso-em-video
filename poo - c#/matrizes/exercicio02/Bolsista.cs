using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public class Bolsista : Pessoa
    {
        //Atributos
        private float bolsa;

        //Chamada explícita ao construtor base
        public Bolsista(string nome, int idade, char sexo, float bolsa) : base(nome, idade, sexo)
        {
            this.Bolsa = bolsa;
        }

        //Método Get e Set
        public float Bolsa { get => bolsa; set => bolsa = value; }

        //Métodos
        public void renovarBolsa()
        {

        }

        //public override void PagarMensalidade()
        //{
        //    Console.Write("Bolsista pagou a mensalidade!");
        //}
    }
}
