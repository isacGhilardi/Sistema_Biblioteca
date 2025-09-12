
# SISTEMA DE BIBLIOTECA - DOCUMENTAÇÃO

## 1. ARQUITETURA DO SISTEMA

### Classes Implementadas:
- **Livro**: Representa um livro com atributos básicos
- **SistemaBiblioteca**: Gerencia a coleção de livros

### Encapsulamento:
- Atributos privados (_livros, _proximoIdLivro)
- Propriedades públicas para acesso controlado
- Métodos públicos para operações

### Construtores:
- Construtor com parâmetros na classe Livro
- Construtor padrão na classe SistemaBiblioteca

## 2. FUNCIONALIDADES

### Cadastro de Livros:
- Entrada de dados via teclado
- Validação de campos obrigatórios
- Geração automática de ID

### Consultas:
- Listagem completa de livros
- Busca por ID
- Exibição formatada das informações

## 3. CÓDIGO FONTE

﻿using System;
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
## 4. CONCLUSÃO

O sistema implementa todos os conceitos de POO solicitados:
- Classes e objetos ✓
- Encapsulamento ✓  
- Construtores ✓
- Abstração ✓

