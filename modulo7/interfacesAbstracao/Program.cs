using System;

public interface IMovimento
{
    void Mover();
}

public class Carro : IMovimento
{
    public void Mover()
    {
        Console.WriteLine("O carro está se movendo.");
    }
}

public class Aviao : IMovimento
{
    public void Mover()
    {
        Console.WriteLine("O avião está voando.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        IMovimento meuCarro = new Carro();
        IMovimento meuAviao = new Aviao();

        meuCarro.Mover();
        meuAviao.Mover();
    }
}
