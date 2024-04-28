// Exercício de fixação

/**
* Fazer um programa para executar a seguinte interação com o
* usuário, lendo os valores destacados em vermelhos, e depois mostrar os dados na tela:
*
* Entre com seu nome completo:
* Alex Green
*
* Quantos quartos tem na sua casa?
* 3
*
* Entre com o preço de um produto:
* 500.50
*
* Entre seu último nome, idade e altura (mesma linha):
* Green 21 1.73
*
* OUTPUT:
*
* Alex Green
* 3
* 500.50
* Green
* 21
* 1.73
*/

using System;

namespace EntradaDeDados
{
    class Exercicio
    {
        public static void SolucaoExercicio()
        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine()!;

            Console.WriteLine("Quantos quartos tem na sua casa? ");
            int quantidadeQuartos = int.Parse(Console.ReadLine()!);

            Console.WriteLine("Entre com o preço de um produto: ");
            float precoProduto = float.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
        
            Console.WriteLine("Entre seu último nome, idade e altura (mesma linha): ");
            string[] vetor = Console.ReadLine()!.Split(' ');

            string sobrenome = vetor[0];
            int idade = int.Parse(vetor[1]);
            float altura = float.Parse(vetor[2], System.Globalization.CultureInfo.InvariantCulture);

            Console.WriteLine(nomeCompleto);
            Console.WriteLine(quantidadeQuartos);
            Console.WriteLine(precoProduto.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
            Console.WriteLine(sobrenome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}