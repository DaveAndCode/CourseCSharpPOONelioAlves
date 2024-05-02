/*
Leia um valor inteiro X (1 <= X <= 1000). Em seguida mostre os ímpares de 1 até X, um valor por linha, inclusive o
X, se for o caso.
Exemplo:
Entrada:      Saída:
8               1
                3
                5
                7
*/

namespace EstruturaFor
{
    class Ex01Aula
    {
        public static void Ex01AulaSolucao()
        {
            int numeroDigitado = int.Parse(Console.ReadLine()!);

            for (int iteracao = 1; iteracao < numeroDigitado; iteracao++)
            {
                if (iteracao % 2 == 1)
                {
                    Console.WriteLine(iteracao);
                }
            }
        }
    }
}