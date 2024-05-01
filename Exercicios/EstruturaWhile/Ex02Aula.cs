/*
Escreva um programa para ler as coordenadas (X,Y) de uma quantidade indeterminada de pontos no sistema
cartesiano. Para cada ponto escrever o quadrante a que ele pertence. O algoritmo será encerrado quando pelo
menos uma de duas coordenadas for NULA (nesta situação sem escrever mensagem alguma).
Exemplo:
Entrada:    Saída:
2 2         primeiro
3 -2        quarto
-8 -1       terceiro
-7 1        segundo
0 2         
*/

namespace EstruturaWhile
{
    class Ex02Aula
    {
        public static void Ex02AulaSolucao()
        {
            Console.WriteLine("Digite as coordenadas X e Y separadas por espaço: ");
            string[] coordenadas = Console.ReadLine()!.Split(' ');
            int x = int.Parse(coordenadas[0]);
            int y = int.Parse(coordenadas[1]);

            while (x != 0 || y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                    Console.WriteLine("Digite as coordenadas X e Y separadas por espaço: ");
                    coordenadas = Console.ReadLine()!.Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x > 0 && y < 0)
                {
                    Console.WriteLine("quarto");
                    Console.WriteLine("Digite as coordenadas X e Y separadas por espaço: ");
                    coordenadas = Console.ReadLine()!.Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x < 0 && y < 0)
                {
                    Console.WriteLine("terceiro");
                    Console.WriteLine("Digite as coordenadas X e Y separadas por espaço: ");
                    coordenadas = Console.ReadLine()!.Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                    Console.WriteLine("Digite as coordenadas X e Y separadas por espaço: ");
                    coordenadas = Console.ReadLine()!.Split(' ');
                    x = int.Parse(coordenadas[0]);
                    y = int.Parse(coordenadas[1]);
                }
                break;
            }

        }
    }
}