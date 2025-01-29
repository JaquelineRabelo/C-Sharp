using System;

class Program
{
    // 2. Variáveis e Constantes
    static void Main(string[] args)
    {
        int numero = 10;
        string mensagem = "Olá, C#";

        // Constantes
        // Uma constante é um valor que nunca muda durante a execução do programa. Use a palavra-chave const:
        const double PI = 3.14159;
        const string AULA = "C# Básico";

        // Operadores Relacionais
        // Operador    Descrição        Exemplo
        // ==          Igual a         10 == 10 → true
        // !=          Diferente de     10 != 5 → true
        // >           Maior que       10 > 5 → true
        // <           Menor que       5 < 10 → true
        // >=          Maior ou igual   10 >= 5 → true
        // <=          Menor ou igual   5 <= 10 → true

        // Cálculos Matemáticos
        int a = 10, b = 5;
        int soma = a + b;
        int produto = a * b;

        Console.WriteLine($"Soma: {soma}, Produto: {produto}");

        // Leitura de Dados do Usuário
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade:");
        int idade = int.Parse(Console.ReadLine());

        Console.WriteLine($"Olá, {nome}. Você tem {idade} anos.");

        // Operadores Lógicos
        bool maiorDeIdade = idade >= 18;
        bool possuiCNH = true;

        if (maiorDeIdade && possuiCNH)
        {
            Console.WriteLine("Você pode dirigir!");
        }
        else
        {
            Console.WriteLine("Você não pode dirigir.");
        }
    }
}
