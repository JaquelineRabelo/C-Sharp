using System;

public class Animal
{
    public virtual void Falar()
    {
        Console.WriteLine("O animal emite um som.");
    }
}

public class Gato : Animal
{
    public override void Falar()
    {
        Console.WriteLine("O gato mia.");
    }
}

public class Program
{
    static void Main(string[] args)
    {
        Animal meuAnimal = new Animal();
        meuAnimal.Falar(); // Saída: O animal emite um som.

        Animal meuGato = new Gato();
        meuGato.Falar(); // Saída: O gato mia.
    }
}
