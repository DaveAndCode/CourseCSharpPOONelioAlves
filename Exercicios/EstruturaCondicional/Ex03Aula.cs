/**
* Fazer um programa para ler um número inteiro e dizer se este número é par ou ímpar.
*/

namespace EstruturaCondicional
{
    class Ex03Aula
    {
        public static void Ex03AulaSolucao()
        {
            int numero = int.Parse(Console.ReadLine()!);
            if (numero % 2 == 0)
            {
                Console.WriteLine("PAR");
            }
            else
            {
                Console.WriteLine("ÍMPAR");
            }
        }
    }
}