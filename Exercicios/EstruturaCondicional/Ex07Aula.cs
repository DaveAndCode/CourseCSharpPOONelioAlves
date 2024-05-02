/*
Leia 2 valores com uma casa decimal (x e y), que devem representar as coordenadas
de um ponto em um plano. A seguir, determine qual o quadrante ao qual pertence o
ponto, ou se está sobre um dos eixos cartesianos ou na origem (x = y = 0).
Se o ponto estiver na origem, escreva a mensagem “Origem”.
Se o ponto estiver sobre um dos eixos escreva “Eixo X” ou “Eixo Y”, conforme for a
situação.
Exemplos:
Entrada:        Saída:
4.5 -2.2        Q4
Entrada:        Saída:
0.1 0.1         Q1
Entrada:        Saída:
0.0 0.0         Origem
*/

namespace EstruturaCondicional
{
    class Ex07Aula
    {
        public static void Ex07AulaSolucao()
        {
            Console.WriteLine("Digite a coordenada do eixo X e Y separados por espaços: ");
            string[] coordenadas = Console.ReadLine()!.Split(' ');
            double eixoX = double.Parse(coordenadas[0]);
            double eixoY = double.Parse(coordenadas[1]);

            if (eixoX > 0 && eixoY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if (eixoX < 0 && eixoY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (eixoX < 0 && eixoY < 0)
            {
                Console.WriteLine("Q3");
            }
            else if (eixoX > 0 && eixoY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (eixoX == 0 && eixoY == 0)
            {
                Console.WriteLine("Origem");
            }
            else if (eixoY == 0 && eixoX > 0)
            {
                Console.WriteLine("Eixo X");
            }
            else if (eixoX == 0 && eixoY > 0)
            {
                Console.WriteLine("Eixo Y");
            }
        }
    }
}