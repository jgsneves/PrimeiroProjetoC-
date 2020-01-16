using System;
using System.Collections.Generic;
using System.Text;

namespace PrimeiroPrograma
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Id { get; set; }

        public Pessoa(string _nome, int _idade, int _id)
        {
            Nome = _nome;
            Idade = _idade;
            Id = _id;
        }

        
        public override string ToString()
        {
            string retorno = String.Empty;

            retorno += String.Format("Nome: {0}", this.Nome) + Environment.NewLine;
            retorno += $"Idade: {this.Idade}" + Environment.NewLine;
            retorno += "Id: " + this.Id + Environment.NewLine;

            return retorno;
        }
                       
    }
}
