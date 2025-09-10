using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    public class Livros
    {
        private string Titulo;
        private string Autor;
        private DateTime DataLançamento;
        private int IdLi;

        public string titulo { get => Titulo; set => Titulo = value; }
        public string autor { get => Autor; set => Autor = value; }
        public DateTime dataLançamento { get => DataLançamento; set => DataLançamento = value; }
        public int Idli { get => IdLi; set => IdLi = value; }

        public Livros() { }

        public Livros(string titulo, string autor, DateTime dataLançamento, int Idli)
        {
            Titulo = titulo;
            Autor = autor;
            DataLançamento = dataLançamento;
            IdLi = Idli;
        }


    }
}