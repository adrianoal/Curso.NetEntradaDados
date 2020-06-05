using System;
using System.Globalization;

namespace EntradaDeDadosEmCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine();
            */


            /*             
            // Exemplo com Split:
            
            string[] vet = Console.ReadLine().Split(' '); // Nao esquece de digitar na tela 3 palavras
            string a = vet[0];
            string b = vet[1];
            string c = vet[2];
            Console.WriteLine("Conteudo das variáveis:");
            Console.WriteLine($"{a} {b} {b}");
            Console.WriteLine();
            Console.WriteLine("Posição das variáveis:");
            Console.WriteLine($"{0} {1} {2}");
            Console.WriteLine();

            */

            // 23.Entrada de dados C# - Parte 2

            /*
            Console.WriteLine("Digite um numero: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou: {n1}");
            Console.WriteLine();

            Console.WriteLine("Digite apenas um caracter: ");
            char ch = char.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou {ch}");
            Console.WriteLine();

            Console.WriteLine("Digite um numero com casas decimas:");
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine($"Você digitou: {n2.ToString("F", CultureInfo.InvariantCulture)}");
            Console.WriteLine();
            */

            /*
            Console.WriteLine("Entre com seu nome, sexo (M/F), idade e altura:");
            string[] vet = Console.ReadLine().Split(' ');
            string nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3], CultureInfo.InvariantCulture);
            Console.WriteLine();
            Console.WriteLine($"Você informou os seguintes dados: {nome} {sexo} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
            */

            // Exercicio de fixação:

            Console.WriteLine("Entre com seu nome completo:");
            string nome = Console.ReadLine();


            Console.WriteLine("Quantos quartos tem sua casa?");
            int quartos = int.Parse(Console.ReadLine());


            Console.WriteLine("Entre com o preço de um produto:");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha):");
            string[] vetor = Console.ReadLine().Split();
            string lastName = vetor[0];
            int idad = int.Parse(vetor[1]);
            double alt = double.Parse(vetor[2], CultureInfo.InvariantCulture);
            Console.WriteLine();

            Console.WriteLine($"{nome}");
            Console.WriteLine($"{quartos}");
            Console.WriteLine($"{preco.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"{lastName}");
            Console.WriteLine($"{idad}");
            Console.WriteLine($"{alt.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine();

            // Imprimindo na mesma linha com INTERPOLAÇÃO:

            Console.WriteLine("Imprimindo na mesma linha com INTERPOLAÇÃO");
            Console.WriteLine($"Seu nome é {nome} " +
                              $"qtde de quartos {quartos} " +
                              $"preço do produto {preco} " +
                              $"seu último nome é {lastName} " +
                              $"sua idade {idad} " +
                              $"sua altura {alt}");

        }
    }
}
