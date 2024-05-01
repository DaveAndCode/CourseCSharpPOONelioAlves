/**
Você deve fazer um programa que leia um valor qualquer e apresente uma mensagem dizendo em qual dos
seguintes intervalos ([0,25], (25,50], (50,75], (75,100]) este valor se encontra. Obviamente se o valor não estiver em
nenhum destes intervalos, deverá ser impressa a mensagem “Fora de intervalo”.
Exemplos:
Entrada:        Saída:
25.01         Intervalo (25,50]
Entrada:        Saída:
25.00         Intervalo [0,25]
*/

namespace EstruturaCondicional
{
    class Ex06Aula
    {
        public static void Ex06AulaSolucao()
        {
            double numero = double.Parse(Console.ReadLine()!);
            string intervalo;

            if (numero >=75 && numero <=100)
            {
                intervalo = "[75, 100]";
            }
            else if (numero <=75 && numero > 50)
            {
                intervalo = "[50, 75]";
            }
            else if (numero <=50 && numero > 25)
            {
                intervalo = "[25, 50]";
            }
            else if (numero <=25 && numero >= 0)
            {
                intervalo = "[0, 25]";
            }
            else
            {
                intervalo = "Fora de intervalo";
            }

            Console.WriteLine("Intervalo " + intervalo);
        }
    }
}