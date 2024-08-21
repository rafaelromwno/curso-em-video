using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace projeto_yt
{
    internal class Gafanhoto : Pessoa
    {
        private string login;
        private int totAssistido = 0;

        //Método Construtor
        public Gafanhoto(string nome, int idade, string sexo, string login) : base(nome, idade, sexo)
        {
            this.Login = login;
            this.TotAssistido = totAssistido;
        }

        //Método Get e Set
        public string Login { get => login; set => login = value; }
        public int TotAssistido { get => totAssistido; set => totAssistido = value; }

        //Sobrescrevendo o método ToString()
        public override string ToString()
        {
            return $"Nome: {this.Nome}, Idade: {this.Idade}, Sexo: {this.Sexo}, Experiência: {this.Experiencia} anos, Login: {login}, Total Assistido: {totAssistido}";
        }
    }
}
