/**
* Fazer um programa para ler o código de uma peça 1, o número de peças 1, o valor unitário de cada peça 1, o
* código de uma peça 2, o número de peças 2 e o valor unitário de cada peça 2. Calcule e mostre o valor a ser pago.
* Exemplos:
* Entrada:       Saída:
* 12 1 5.30    VALOR A PAGAR: R$ 15.50
* 16 2 5.10
*
* Entrada:       Saída:
* 13 2 15.30   VALOR A PAGAR: R$ 51.40
* 161 4 5.20
* 
* Entrada:       Saída:
* 1 1 15.10    VALOR A PAGAR: R$ 30.20
* 2 1 15.10
*/
using System.Globalization;
namespace EstruturaSequencial
{
    class Ex05Aula
    {
        public static void Ex05AulaSolucao()
        {
            int cod1, cod2, qte1, qte2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qte1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qte2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            total = preco1 * qte1 + preco2 * qte2;

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}