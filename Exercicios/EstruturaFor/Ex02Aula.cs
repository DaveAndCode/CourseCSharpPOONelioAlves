/*
Leia um valor inteiro N. Este valor será a quantidade de valores inteiros X que serão lidos em seguida.
Mostre quantos destes valores X estão dentro do intervalo [10,20] e quantos estão fora do intervalo, mostrando
essas informações conforme exemplo (use a palavra "in" para dentro do intervalo, e "out" para fora do intervalo).
Exemplo:
Entrada: Saída:
5         2 in
14        3 out
123
10
-25
32
*/

namespace EstruturaFor
{
    class Ex02Aula
    {
        public static void Ex02AulaSolucao()
        {
            Console.Write("Digite a quantidade de valores que serão lidos: ");
            int quantidadeValores = int.Parse(Console.ReadLine()!);
            int dentro = 0;
            int fora = 0;

            for (int iteracao = 0; iteracao < quantidadeValores; iteracao++)
            {
                Console.Write("Digite o valor: ");
                int valor = int.Parse(Console.ReadLine()!);
                
                if (valor >= 10 && valor <= 20)
                {
                    dentro++;
                }
                else if (valor < 10 || valor > 20)
                {
                    fora++;
                }
                Console.WriteLine($"{dentro} in");
                Console.WriteLine($"{fora} out");
            }
        }
    }
}