using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Tratamento de Exceções
        try
        {
            Console.WriteLine("Digite um número inteiro:");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine($"Você digitou: {numero}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Você não digitou um número válido!");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execução do bloco try/catch finalizada.");
        }

        // Trabalhando com Coleções
        List<string> frutas = new List<string>
        {
            "Maçã",
            "Banana",
            "Laranja",
            "Manga"
        };

        // Adicionando uma fruta
        frutas.Add("Pera");

        // Exibindo as frutas
        Console.WriteLine("Lista de Frutas:");
        foreach (var fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        // Usando LINQ para consultar a lista
        var frutasComA = from fruta in frutas
                         where fruta.StartsWith("A")
                         select fruta;

        Console.WriteLine("Frutas que começam com a letra 'A':");
        foreach (var fruta in frutasComA)
        {
            Console.WriteLine(fruta);
        }

        // Trabalhando com Dicionários
        Dictionary<string, int> idades = new Dictionary<string, int>
        {
            { "Alice", 25 },
            { "Bob", 30 },
            { "Charlie", 35 }
        };

        // Adicionando uma nova entrada
        idades["Diana"] = 28;

        // Exibindo idades
        Console.WriteLine("Idades:");
        foreach (var item in idades)
        {
            Console.WriteLine($"{item.Key}: {item.Value} anos");
        }
    }
}


/*Conteúdo Programático
Tratamento de Exceções

O que são exceções?
Estruturas try, catch, finally.
Criação de exceções personalizadas.
Coleções em C#

Arrays: definição e manipulação.
Listas: como usar a classe List<T>.
Dicionários: como usar a classe Dictionary<TKey, TValue>.
Outros tipos de coleções.
LINQ (Language Integrated Query)

O que é LINQ?
Sintaxe de consulta e sintaxe de método.
Exemplos de uso do LINQ em listas e arrays.
Exercícios Práticos

Criar um programa que trate exceções.
Trabalhar com diferentes coleções.
Realizar consultas usando LINQ.*/