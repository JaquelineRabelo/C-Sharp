// Módulo 6: Exercícios de Manipulação de Arquivos e Banco de Dados

using System;
using System.IO;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace Modulo6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha um exercício para executar:");
            Console.WriteLine("1 - Leitura e Escrita em Arquivos");
            Console.WriteLine("2 - Manipulação de JSON");
            Console.WriteLine("3 - Conexão com Banco de Dados");
            Console.WriteLine("4 - CRUD em Banco de Dados");
            Console.WriteLine("5 - Consulta SQL com LINQ");
            
            string escolha = Console.ReadLine();
            
            switch (escolha)
            {
                case "1": Exercicio1Arquivo(); break;
                case "2": Exercicio2Json(); break;
                case "3": Exercicio3BancoDados(); break;
                case "4": Exercicio4Crud(); break;
                case "5": Exercicio5Linq(); break;
                default: Console.WriteLine("Opção inválida."); break;
            }
        }

        static void Exercicio1Arquivo()
        {
            string caminho = "exemplo.txt";
            File.WriteAllText(caminho, "Este é um exemplo de escrita em arquivo.");
            string conteudo = File.ReadAllText(caminho);
            Console.WriteLine("Conteúdo do arquivo: " + conteudo);
        }

        static void Exercicio2Json()
        {
            var dados = new { Nome = "João", Idade = 25 };
            string json = JsonConvert.SerializeObject(dados);
            File.WriteAllText("dados.json", json);
            string conteudo = File.ReadAllText("dados.json");
            Console.WriteLine("JSON Lido: " + conteudo);
        }

        static void Exercicio3BancoDados()
        {
            string conexaoString = "your_connection_string_here";
            using (SqlConnection conexao = new SqlConnection(conexaoString))
            {
                try
                {
                    conexao.Open();
                    Console.WriteLine("Conexão com o banco de dados estabelecida.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Erro: " + ex.Message);
                }
            }
        }

        static void Exercicio4Crud()
        {
            Console.WriteLine("CRUD de exemplo para banco de dados.");
            // Implementação do CRUD (Create, Read, Update, Delete)
        }

        static void Exercicio5Linq()
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };
            var pares = numeros.Where(n => n % 2 == 0);
            Console.WriteLine("Números pares: " + string.Join(", ", pares));
        }
    }
}
