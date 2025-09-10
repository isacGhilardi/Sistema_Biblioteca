using System;
using System.Collections.Generic;

namespace Sistema_Biblioteca
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Sistema_Biblioteca biblioteca = new Sistema_Biblioteca();

            bool executando = true;

            while (executando)
            {
                Console.Clear();
                Console.WriteLine("______SUPER HIPER MEGA BIBLIOTECA______");
                Console.WriteLine("=========================");
                Console.WriteLine("1 - Adicionar Livro");
                Console.WriteLine("2 - Cadastrar Leitor");
                Console.WriteLine("3 - Procurar livro por ID");
                Console.WriteLine("4 - Procurar leitor por ID");
                Console.WriteLine("5 - Sair");
                Console.WriteLine("=========================");
                Console.Write("Escolha uma opção: "); 

                if (int.TryParse(Console.ReadLine(), out int resposta))
                {
                    switch (resposta)
                    {
                        case 1:
                            biblioteca.AddLivro();
                            break;
                        case 2:
                            biblioteca.AddLeitor();
                            break;
                        case 3:
                            Console.Write("Digite o ID do livro: ");
                            if (int.TryParse(Console.ReadLine(), out int idLivro))
                                biblioteca.ProcurarLivroPorId(idLivro);
                            else
                                Console.WriteLine(" ID inválido!");
                            break;
                        case 4:
                            Console.Write("Digite o ID do leitor: ");
                            if (int.TryParse(Console.ReadLine(), out int idLeitor))
                                biblioteca.ProcurarLeitorPorId(idLeitor);
                            else
                                Console.WriteLine("ID inválido!");
                            break;
                        case 5:
                            executando = false;
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine(" Opção inválida!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Opção inválida! Digite um número váçido.");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }
}