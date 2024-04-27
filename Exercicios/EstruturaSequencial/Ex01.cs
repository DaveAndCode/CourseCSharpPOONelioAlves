/**
            * PARTE 1: ESTRUTURA SEQUENCIAL
            * Exercício 1.1:
            * Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
            * código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
            *
            * Exemplos:
            *   Entrada:                     Saída:
            *   12 1 5.30            VALOR A PAGAR: R$ 15.50
            *   16 2 5.10
            * 
            * Entrada:                       Saída:
            * 13  2 15.30            VALOR A PAGAR: R$ 51.40
            * 161 4 5.20
            * 
            * Entrada:                       Saída:
            * 1 1 15.10              VALOR A PAGAR: R$ 30.20
            * 2 1 15.10
            */
            
namespace Exercicios
{
    class Ex01
    {
        public static void Exercicio01()
        {
            Console.Write("Digite o código da peça [1° Produto]: ");
            int peca1Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a qtd de peças [1° Produto]: ");
            int peca1Qtd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o preço da unidade [1° Produto]: ");
            float peca1Preco = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite o código da peça [2° Produto]: ");
            int peca2Codigo = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a qtd de peças [2° Produto]: ");
            int peca2Qtd = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o preço da unidade [2° Produto]: ");
            float peca2Preco = Convert.ToSingle(Console.ReadLine());

            float valorTotal = (peca1Qtd * peca1Preco) + (peca2Qtd * peca2Preco);

            Console.WriteLine($"VALOR A PAGAR: R${valorTotal:0.00}");
        }
    }
}

            