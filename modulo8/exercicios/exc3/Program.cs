using System;
// Modelagem de Veículos (Herança e Polimorfismo)
// Classe base
class Veiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Modelo: {Modelo}, Ano: {Ano}");
    }
}

// Classe derivada Carro
class Carro : Veiculo
{
    public int Portas { get; set; }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Portas: {Portas}");
    }
}

// Classe derivada Moto
class Moto : Veiculo
{
    public bool TemPartidaEletrica { get; set; }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Partida elétrica: {TemPartidaEletrica}");
    }
}

class Program
{
    static void Main()
    {
        Carro carro = new Carro { Modelo = "Sedan", Ano = 2022, Portas = 4 };
        Moto moto = new Moto { Modelo = "Esportiva", Ano = 2021, TemPartidaEletrica = true };

        carro.ExibirInfo();
        Console.WriteLine();
        moto.ExibirInfo();
    }
}
