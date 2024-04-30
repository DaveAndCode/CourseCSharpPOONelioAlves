/**
* Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
* começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
* Exemplos:
* Entrada:      Saída:
* 16   2       O JOGO DUROU 10 HORA(S)
* 0    0       O JOGO DUROU 24 HORA(S)
*/

namespace EstruturaCondicional
{
    class Ex04Aula
    {
        public static void Ex04AulaSolucao()
        {
            Console.Write("Digite a hora inicial do jogo: ");
            int horaInicial = int.Parse(Console.ReadLine()!);

            Console.Write("Digite a hora final do jogo: ");
            int horaFinal = int.Parse(Console.ReadLine()!);

            if (horaInicial < horaFinal)
            {
                int duracao = horaFinal - horaInicial;
                System.Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
            else
            {
                int duracao = 24 - horaInicial + horaFinal;
                Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
            }
        }
    }
}