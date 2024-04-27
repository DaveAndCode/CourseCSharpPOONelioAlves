/**
* Exercício 1.2:
* Faça um programa para ler o valor do raio de um círculo, e depois mostrar o valor da área deste círculo com quatro
* casas decimais conforme exemplos.
* Fórmula: area = PI x raio^2
* Considere o valor de π = 3.14159
* Exemplos:
* Entrada:       Saída:
* 2.00          A=12.5664
* Entrada:       Saída:
* 100.64        A=31819.3103
* Entrada:       Saída:
* 150.00        A=70685.7750
*/

using System.Globalization;

namespace EstruturaSequencial
{
    class Ex02
    {
        public static void Exercicio02()
        {
            Console.WriteLine("###Calcular área de um circulo###");
            Console.Write("Digite o raio do círculo: ");
            var raio = Convert.ToDecimal(Console.ReadLine());
            decimal PI = 3.14159M;
            decimal area = PI * raio * raio;
            Console.WriteLine(@$"
Entrada:          Saída:
{raio.ToString("F2", CultureInfo.InvariantCulture)}              A={area.ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}