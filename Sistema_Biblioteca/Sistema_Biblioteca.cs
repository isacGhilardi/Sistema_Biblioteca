using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_Biblioteca
{
    public class Sistema_Biblioteca : Livros
    {
        private List<Livros> livros = new List<Livros>();
        private List<Leitor> leitores = new List<Leitor>();
        private int _proximoIdLeitor = 1000;
        private int _proximoIdLivro = 1000;
        public void AddLivro()
        {
            Console.WriteLine("\n ADICIONAR NOVO LIVRO ");
            Console.WriteLine("_______________________");
            Console.Write("Digite o título do livro: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite o autor do livro: ");
            string autor = Console.ReadLine();
            DateTime dataLancamento;
            while (true)
            {
                Console.Write("Digite a data de lançamento (dd/MM/aaaa): ");
                string inputData = Console.ReadLine();

                if (DateTime.TryParse(inputData, out dataLancamento))
                {
                    break;
                }
                Console.WriteLine(" Data inválida! Digite no formato dd/MM/aaaa.");
            }
            var nvlivro = new Livros(titulo, autor, dataLancamento, _proximoIdLivro++);
            livros.Add(nvlivro);
            Console.WriteLine($"✓ Livro '{titulo}' adicionado com sucesso! (ID: {nvlivro.Idli})");
        }
        public void AddLeitor()
        {
            Console.WriteLine("\n ADICIONAR NOVO LEITOR ");
            Console.WriteLine("_______________________");
            Console.Write("Digite o nome do leitor: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o cpf do leitor: ");
            int Cpf = int.Parse(Console.ReadLine());
            DateTime dataN;
            while (true)
            {
                Console.Write("Digite a data de lançamento (dd/MM/aaaa): ");
                string inputData = Console.ReadLine();

                if (DateTime.TryParse(inputData, out dataN))
                {
                    break;
                }
                Console.WriteLine(" Data inválida! Digite no formato dd/MM/aaaa.");
            }
            var nvleitor = new Leitor(nome, Cpf, dataN, _proximoIdLeitor++);
            leitores.Add(nvleitor);
            Console.WriteLine($"✓ Leitor '{nome}' cadastrado com sucesso! (ID: {nvleitor.Idleitores})");
        }
        public void ProcurarLeitorPorId(int id)
        {
            var leitor = leitores.Find(l => l.Idleitores == id);

            if (leitor != null)
            {
                Console.WriteLine($"ID: {leitor.Idleitores}");
                Console.WriteLine($"Nome: {leitor.nome}");
                Console.WriteLine($"CPF: {leitor.Cpf}");
                Console.WriteLine($"Data Cadastro: {leitor.dataN:dd/MM/yyyy}");
                Console.WriteLine("------------");
            }
            else
            {
                Console.WriteLine($"Leitor com ID {id} não encontrado.");
            }
        }
        public void ProcurarLivroPorId(int id)
        {
            var livro = livros.Find(l => l.Idli == id);

            if (livro != null)
            {
                Console.WriteLine($"\n---INFORMAÇÕES DO LIVRO POR ID {id}----");
                Console.WriteLine($"Título: {livro.titulo}");
                Console.WriteLine($"Autor: {livro.autor}");
                Console.WriteLine($"Lançamento: {livro.dataLançamento:dd/MM/yyyy}");
            }
            else
            {
                Console.WriteLine($"Livro com ID {id} não encontrado.");
            }

        }
    }
}
