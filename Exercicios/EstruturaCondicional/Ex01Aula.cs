/**
* Fazer um programa para ler um número inteiro, e depois dizer se este número é negativo ou não.
* Exemplos:
* Entrada:    Saída:
* -10        NEGATIVO
*
* Entrada:    Saída:
* 8 NAO      NEGATIVO
* Entrada:    Saída:
* 0          NAO NEGATIVO
*/

namespace EstruturaCondicional
{
    class Ex01Aula
    {
        public static void Ex01AulaSolucao()
        {
            Console.WriteLine("Digite um número inteiro: ");
            int numeroDigitado = int.Parse(Console.ReadLine()!);

            if (numeroDigitado < 0)
            {
                Console.WriteLine("NEGATIVO");
            }
            else
            {
                Console.WriteLine("NÃO NEGATIVO");
            }
        }
    }
}