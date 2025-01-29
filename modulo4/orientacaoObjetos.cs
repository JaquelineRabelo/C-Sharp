using System;

// Classe base
class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public virtual void FazerSom()
    {
        Console.WriteLine($"{Nome} faz um som.");
    }
}

// Classe derivada
class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Au Au!");
    }
}

// Classe derivada
class Gato : Animal
{
    public Gato(string nome) : base(nome) { }

    public override void FazerSom()
    {
        Console.WriteLine($"{Nome} diz: Miau!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Estruturas de controle
        Console.WriteLine("Escolha um animal (1 - Cachorro, 2 - Gato): ");
        int escolha = int.Parse(Console.ReadLine());

        Animal animal;

        switch (escolha)
        {
            case 1:
                Console.WriteLine("Digite o nome do cachorro:");
                string nomeCachorro = Console.ReadLine();
                animal = new Cachorro(nomeCachorro);
                break;
            case 2:
                Console.WriteLine("Digite o nome do gato:");
                string nomeGato = Console.ReadLine();
                animal = new Gato(nomeGato);
                break;
            default:
                Console.WriteLine("Escolha inválida.");
                return;
        }

        animal.FazerSom();
    }
}



//Objetivos do Módulo
/*Entender e utilizar estruturas de controle de fluxo (condicionais e loops).
Compreender os princípios da programação orientada a objetos (POO).
Criar classes e objetos.
Implementar herança, encapsulamento e polimorfismo.-->*/

/*
Programação Orientada a Objetos

Definição de classe e objeto
Propriedades e métodos
Construtores e destrutores
Herança
Polimorfismo
Encapsulamento*/
