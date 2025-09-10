using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    public class Leitor
    {
        private int IdLeitores;
        private string Nome;
        private int cpf;
        private DateTime DataN;

        public int Idleitores { get => IdLeitores; set => IdLeitores = value; }
        public string nome { get => Nome; set => Nome = value; }
        public int Cpf { get => cpf; set => cpf = value; }
        public DateTime dataN { get => DataN; set => DataN = value; }

        public Leitor(string nome, int Cpf, DateTime dataN, int Idleitores)
        {
            Nome = nome;
            cpf = Cpf;
            DataN = dataN;
            IdLeitores = Idleitores;
        }
    }
}
