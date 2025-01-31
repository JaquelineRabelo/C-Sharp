using System;

public class Carro
{
    // Campos privados
    private string modelo;
    private string cor;
    private int ano;

    // Propriedades públicas para acessar os campos privados
    public string Modelo
    {
        get { return modelo; }
        set { modelo = value; }
    }

    public string Cor
    {
        get { return cor; }
        set { cor = value; }
    }

    public int Ano
    {
        get { return ano; }
        set { ano = value; }
    }

    // Método público
    public void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}, Ano: {Ano}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Carro meuCarro = new Carro();
        meuCarro.Modelo = "Fusca";
        meuCarro.Cor = "Azul";
        meuCarro.Ano = 1970;

        meuCarro.ExibirInfo();
    }
}
