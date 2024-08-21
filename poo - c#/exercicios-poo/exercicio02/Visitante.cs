using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicio02
{
    public class Visitante : Pessoa
    {
        //chamada explícita ao construtor base
        public Visitante(string nome, int idade, char sexo) : base(nome, idade, sexo)
        {
        }
    }
}
