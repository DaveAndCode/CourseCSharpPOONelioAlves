/**
* Fazer um programa que leia o número de um funcionário, seu número de horas trabalhadas, o valor que recebe por
* hora e calcula o salário desse funcionário. A seguir, mostre o número e o salário do funcionário, com duas casas
* decimais.
* Exemplos:
* Entrada:    Saída:
*   25      NUMBER = 25
*   100     SALARY = U$ 550.00
*   5.50
*
* Entrada:    Saída:
*    1      NUMBER = 1
*    200    SALARY = U$ 4100.00
*    20.50
*
* Entrada:      Saída:
*    6          NUMBER = 6
*    145        SALARY = U$ 2254.75
*    15.55
*/

namespace EstruturaSequencial
{
    class Ex04Aula
    {
        public static void Ex04AulaSolucao()
        {
            Console.Write("Digite o número do funcionário: ");
            int numFuncionario = int.Parse(Console.ReadLine()!);
            Console.Write("Digite o número de horas trabalhadas: ");
            float horasTrabalhadas = float.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            Console.Write("Digite o valor da hora trabalhada: ");
            float valorHoraTrabalhada = float.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            float salario = horasTrabalhadas * valorHoraTrabalhada;
            Console.WriteLine($"NUMBER = {numFuncionario}");
            Console.WriteLine($"SALARY = {salario.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");

        }
    }
}