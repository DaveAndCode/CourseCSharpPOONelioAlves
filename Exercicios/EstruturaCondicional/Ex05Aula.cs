/**
* Com base na tabela abaixo, escreva um programa que leia o código de um item e a quantidade deste item. A
* seguir, calcule e mostre o valor da conta a pagar.
* Código:        Especificação:        Preço:
* 1              Cachorro Quente       R$4.00
* 2              X-Salada              R$4.50
* 3              X-Bacon               R$5.00
* 4              Torrada simples       R$2.00
* 5              Refrigerante          R$1.50
*/
using System.Globalization;
namespace EstruturaCondicional
{
    class Ex05Aula
    {
        public static void Ex05AulaSolucao()
        {
            string[] valores = Console.ReadLine()!.Split(' ');
            int id = int.Parse(valores[0]);
            double qtd = double.Parse(valores[1], CultureInfo.InvariantCulture);

            if (id == 1)
            {
                string nomeProduto = "Cachorro quente";
                double precoProduto = 4.00;
                double valorFinal = precoProduto * qtd;
                Console.WriteLine(@$"Você selecionou o produto ({nomeProduto}).
que tem valor de unidade = R${precoProduto}.
quantidade desejada: {qtd}.
valor total = R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (id == 2)
            {
                 string nomeProduto = "X-Salada";
                double precoProduto = 4.50;
                double valorFinal = precoProduto * qtd;
                Console.WriteLine(@$"Você selecionou o produto ({nomeProduto}).
que tem valor de unidade = R${precoProduto}.
quantidade desejada: {qtd}.
valor total = R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (id == 3)
            {
                string nomeProduto = "X-Bacon";
                double precoProduto = 5.00;
                double valorFinal = precoProduto * qtd;
                Console.WriteLine(@$"Você selecionou o produto ({nomeProduto}).
que tem valor de unidade = R${precoProduto}.
quantidade desejada: {qtd}.
valor total = R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (id == 4)
            {
                string nomeProduto = "Torrada simples";
                double precoProduto = 2.00;
                double valorFinal = precoProduto * qtd;
                Console.WriteLine(@$"Você selecionou o produto ({nomeProduto}).
que tem valor de unidade = R${precoProduto}.
quantidade desejada: {qtd}.
valor total = R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else if (id == 5)
            {
                string nomeProduto = "Refrigerante";
                double precoProduto = 1.50;
                double valorFinal = precoProduto * qtd;
                Console.WriteLine(@$"Você selecionou o produto ({nomeProduto}).
que tem valor de unidade = R${precoProduto}.
quantidade desejada: {qtd}.
valor total = R${valorFinal.ToString("F2", CultureInfo.InvariantCulture)}.");
            }
            else
            {
                Console.WriteLine("Valor digitado incorreto");
            }
        }
    }
}