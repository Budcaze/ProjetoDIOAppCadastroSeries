using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIO.SERIES
{
    public class Anime : EntidadeBase
    {
        private String Nome { get; set; }
        private String Descricao { get; set; }
        private Genero Genero { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        public Anime(int id, Genero genero, string nome, string descricao, int ano)
        {
            this.Genero = genero;
            this.Nome = nome;  
            this.Descricao = descricao;
            this.Ano = ano;
            this.id = id;
            this.Excluido = false;
        }
        
        public String retornaNome()
        {
            return this.Nome;
        }
        public int retornaId()
        {
            return this.id;
        }
        public bool retornaExcluido()
        {
            return this.Excluido;
        }

        public void Excluir()
        {
            this.Excluido=true;
        }
        public override string ToString()
        {
            string retorno = "";
            retorno += "Gênero: " + this.Genero + Environment.NewLine;
            retorno += "Nome: " + this.Nome + Environment.NewLine;
            retorno += "Descrição: " + this.Descricao + Environment.NewLine;
            retorno += "Ano de Lançamento: " + this.Ano + Environment.NewLine;
            retorno += "Exluido: " + this.Excluido + Environment.NewLine;
            return retorno;
        }

        public override bool Equals(object? obj)
        {
            return obj is Anime anime &&
                   Nome == anime.Nome &&
                   Genero == anime.Genero &&
                   Ano == anime.Ano;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Genero, Ano);
        }
    }
}
