using System;
using System.Collections.Generic;
//  Cadastro de Usuários
class Usuario
{
    public string Nome { get; set; }
    public int Idade { get; set; }
}

class Program
{
    static List<Usuario> usuarios = new List<Usuario>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\n1 - Adicionar usuário");
            Console.WriteLine("2 - Listar usuários");
            Console.WriteLine("3 - Remover usuário");
            Console.WriteLine("4 - Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    AdicionarUsuario();
                    break;
                case 2:
                    ListarUsuarios();
                    break;
                case 3:
                    RemoverUsuario();
                    break;
                case 4:
                    return;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }

    static void AdicionarUsuario()
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Idade: ");
        int idade = int.Parse(Console.ReadLine());

        usuarios.Add(new Usuario { Nome = nome, Idade = idade });
        Console.WriteLine("Usuário adicionado!");
    }

    static void ListarUsuarios()
    {
        Console.WriteLine("\nLista de usuários:");
        foreach (var user in usuarios)
            Console.WriteLine($"Nome: {user.Nome}, Idade: {user.Idade}");
    }

    static void RemoverUsuario()
    {
        Console.Write("Informe o nome do usuário a remover: ");
        string nome = Console.ReadLine();

        usuarios.RemoveAll(u => u.Nome == nome);
        Console.WriteLine("Usuário removido!");
    }
}
