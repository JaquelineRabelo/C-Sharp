using System;

// Estruturas de Controle: if e else

int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}

// Adicionando mais condições ao controle com else if
int nota = 85;

if (nota >= 90)
{
    Console.WriteLine("Parabéns! Você tirou A.");
}
else if (nota >= 70)
{
    Console.WriteLine("Boa! Você tirou B.");
}
else
{
    Console.WriteLine("Estude mais! Você tirou C.");
}

// Usando switch para várias comparações
int diaSemana = 3;

switch (diaSemana)
{
    case 1:
        Console.WriteLine("Segunda-feira");
        break;
    case 2:
        Console.WriteLine("Terça-feira");
        break;
    case 3:
        Console.WriteLine("Quarta-feira");
        break;
    default:
        Console.WriteLine("Dia inválido");
        break;
}

// Estruturas de Repetição

// 1. for - Executa um bloco de código com contador
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Contagem: {i}");
}

// 2. while - Repete enquanto a condição for verdadeira
int contador = 1;

while (contador <= 5)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;
}

// 3. do-while - Executa pelo menos uma vez antes de verificar a condição
int numero;

do
{
    Console.WriteLine("Digite um número positivo:");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine($"Você digitou o número {numero}.");

// Exemplos Práticos

// 1. Calculando a soma dos números de 1 até n
Console.WriteLine("Digite um número:");
int n = int.Parse(Console.ReadLine());

int soma = 0;
for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma de 1 até {n} é {soma}.");

// 2. Validação de entrada: Nota entre 0 e 10
int notaValida;

do
{
    Console.WriteLine("Digite uma nota entre 0 e 10:");
    notaValida = int.Parse(Console.ReadLine());
} while (notaValida < 0 || notaValida > 10);

Console.WriteLine($"A nota digitada foi: {notaValida}");

// 3. Menu interativo
int opcao;

do
{
    Console.WriteLine("\nEscolha uma opção:");
    Console.WriteLine("1 - Exibir mensagem");
    Console.WriteLine("2 - Calcular soma");
    Console.WriteLine("0 - Sair");
    opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Olá, bem-vindo ao menu!");
            break;
        case 2:
            Console.WriteLine("Digite dois números:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma é: {a + b}");
            break;
        case 0:
            Console.WriteLine("Saindo...");
            break;
        default:
            Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }
} while (opcao != 0);
