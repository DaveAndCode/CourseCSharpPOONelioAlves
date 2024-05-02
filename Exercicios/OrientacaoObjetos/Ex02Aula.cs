/*
Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário
médio dos funcionários.
Exemplo:
Dados do primeiro funcionário:
Nome: Carlos Silva
Salário: 6300.00

Dados do segundo funcionário:
Nome: Ana Marques
Salário: 6700.00

Salário médio = 6500.00
*/
using System.Globalization;
namespace OrientacaoObjetos
{
    class Ex02Aula
    {
        public static void SolucaoExercicio()
        {
            Funcionario primeiroFuncionario, segundoFuncionario;
            primeiroFuncionario = new();
            segundoFuncionario = new();
            Console.WriteLine("Dados do primeiro funcionário:");
            Console.Write("Nome: ");
            primeiroFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ", CultureInfo.InvariantCulture);
            primeiroFuncionario.Salario = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Dados do segundo funcionário:");
            Console.Write("Nome: ");
            segundoFuncionario.Nome = Console.ReadLine();
            Console.Write("Salário: ", CultureInfo.InvariantCulture);
            segundoFuncionario.Salario = double.Parse(Console.ReadLine()!);

            double salarioMedio = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2;
            Console.WriteLine("Salário médio = " + salarioMedio.ToString("F2", CultureInfo.InvariantCulture));


        }
    }

    class Funcionario
    {
        public string? Nome;
        public double Salario;
    }
}