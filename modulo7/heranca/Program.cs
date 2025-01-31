using System;

public class Animal
{
    public string Nome { get; set; }

    public Animal(string nome)
    {
        Nome = nome;
    }

    public void Dormir()
    {
        Console.WriteLine($"{Nome} está dormindo.");
    }
}

public class Cachorro : Animal
{
    public Cachorro(string nome) : base(nome) { }

    public void Latir()
    {
        Console.WriteLine($"{Nome} está latindo.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Cachorro cachorro = new Cachorro("Rex");
        cachorro.Dormir();
        cachorro.Latir();
    }
}
