// if e else

if (condição)
{
    // Código a ser executado se a condição for verdadeira
}
else
{
    // Código a ser executado se a condição for falsa
}


int idade = 18;

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade.");
}
else
{
    Console.WriteLine("Você é menor de idade.");
}


// Adiciona mais condições ao controle.
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

//Uma alternativa ao if para comparar uma variável com vários valores.
switch (variavel)
{
    case valor1:
        // Código para valor1
        break;
    case valor2:
        // Código para valor2
        break;
    default:
        // Código padrão
        break;
}

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


//2. Estruturas de Repetição


for (inicialização; condição; incremento)
{
    // Código a ser repetido
}

for (int i = 1; i <= 5; i++)
{
    Console.WriteLine($"Contagem: {i}");
}

//2.2 while - Repete um bloco de código enquanto a condição for verdadeira.

while (condição)
{
    // Código a ser repetido
}

int contador = 1;

while (contador <= 5)
{
    Console.WriteLine($"Contagem: {contador}");
    contador++;
}


//o-while - Garante que o bloco de código será executado pelo menos uma vez antes de verificar a condição.
do
{
    // Código a ser repetido
} while (condição);

//

int numero;

do
{
    Console.WriteLine("Digite um número positivo:");
    numero = int.Parse(Console.ReadLine());
} while (numero <= 0);

Console.WriteLine($"Você digitou o número {numero}.");

// . Exemplos Práticos
//3.1 Calculando a Soma dos Números
//Peça ao usuário um número n e calcule a soma dos números de 1 até n.

Console.WriteLine("Digite um número:");
int n = int.Parse(Console.ReadLine());

int soma = 0;
for (int i = 1; i <= n; i++)
{
    soma += i;
}

Console.WriteLine($"A soma de 1 até {n} é {soma}.");


//3.2 Validação de Entrada
//Peça uma nota entre 0 e 10. Repita enquanto o valor for inválido.

int nota;

do
{
    Console.WriteLine("Digite uma nota entre 0 e 10:");
    nota = int.Parse(Console.ReadLine());
} while (nota < 0 || nota > 10);

Console.WriteLine($"A nota digitada foi: {nota}");

//3.3 Menu Interativo
//Crie um menu que execute operações diferentes dependendo da escolha do usuário.

int opcao;

do
{
    Console.WriteLine("Escolha uma opção:");
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
            Console.WriteLine("Opção inválida!");
            break;
    }
} while (opcao != 0);