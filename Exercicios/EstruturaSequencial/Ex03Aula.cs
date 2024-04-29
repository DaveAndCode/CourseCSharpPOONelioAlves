/**
* Fazer um programa para ler quatro valores inteiros A, B, C e D. A seguir, calcule e mostre a diferença do produto
* de A e B pelo produto de C e D segundo a fórmula: DIFERENCA = (A * B - C * D).
* Exemplos:
* Entrada:           Saída:
*    5              DIFERENCA = -26
*    6
*    7
*    8

* Entrada:            Saída:
*    5              DIFERENCA = 86
*    6
*  - 7
*    8
*/

namespace EstruturaSequencial
{
    class Ex03Aula
    {
        public static void Ex03AulaSolucao()
        {
            int valorA = int.Parse(Console.ReadLine()!);
            int valorB = int.Parse(Console.ReadLine()!);
            int valorC = int.Parse(Console.ReadLine()!);
            int valorD = int.Parse(Console.ReadLine()!);
            int diferenca = (valorA * valorB) - (valorC * valorD);
            Console.WriteLine("DIFERENCA = " + diferenca);
        }
    }
}