using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Configura a pasta wwwroot para servir arquivos estáticos
app.UseStaticFiles();

// Rota padrão que redireciona para o index.html
app.MapGet("/", () => Results.Redirect("/index.html"));

using System;

namespace ConversorMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conversor de Moedas!");

            bool executando = true;

            while (executando)
            {
                Console.WriteLine("Selecione uma opção:");
                Console.WriteLine("1 - Real para Dólar");
                Console.WriteLine("2 - Real para Euro");
                Console.WriteLine("3 - Dólar para Real");
                Console.WriteLine("4 - Euro para Real");
                Console.WriteLine("5 - Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        RealParaDolar();
                        break;
                    case 2:
                        RealParaEuro();
                        break;
                    case 3:
                        DolarParaReal();
                        break;
                    case 4:
                        EuroParaReal();
                        break;
                    case 5:
                        executando = false;
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }

        static void RealParaDolar()
        {
            Console.WriteLine("Digite o valor em Real: ");
            decimal valorReal = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 5.23m; // Taxa de câmbio do dólar em relação ao real

            decimal valorDolar = valorReal / taxaCambio;

            Console.WriteLine("Valor em Dólar: " + valorDolar);
        }

        static void RealParaEuro()
        {
            Console.WriteLine("Digite o valor em Real: ");
            decimal valorReal = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 6.19m; // Taxa de câmbio do euro em relação ao real

            decimal valorEuro = valorReal / taxaCambio;

            Console.WriteLine("Valor em Euro: " + valorEuro);
        }

        static void DolarParaReal()
        {
            Console.WriteLine("Digite o valor em Dólar: ");
            decimal valorDolar = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 5.23m; // Taxa de câmbio do dólar em relação ao real

            decimal valorReal = valorDolar * taxaCambio;

            Console.WriteLine("Valor em Real: " + valorReal);
        }

        static void EuroParaReal()
        {
            Console.WriteLine("Digite o valor em Euro: ");
            decimal valorEuro = Convert.ToDecimal(Console.ReadLine());

            decimal taxaCambio = 6.19m; // Taxa de câmbio do euro em relação ao real

            decimal valorReal = valorEuro * taxaCambio;

            Console.WriteLine("Valor em Real: " + valorReal);
        }
    }
}
app.Run();

