/*
Fazer um programa para ler os dados de um funcionário (nome,
salário bruto e imposto). Em seguida, mostrar os dados do
funcionário (nome e salário líquido). Em seguida, aumentar o salário
do funcionário com base em uma porcentagem dada (somente o
salário bruto é afetado pela porcentagem) e mostrar novamente os
dados do funcionário. Use a classe projetada abaixo.
Exemplo:
Nome: Joao Silva
Salário bruto: 6000.00
Imposto: 1000.00
Funcionário: Joao Silva, $ 5000.00
Digite a porcentagem para aumentar o salário: 10.0
Dados atualizados: Joao Silva, $ 5600.00
*/
using System.Globalization;
namespace OrientacaoObjetoss
{
    class Ex02Fixacao
    {
        public static void Solucao()
        {
            Funcionario funcionario = new();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine()!;

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.Write("Imposto: ", CultureInfo.InvariantCulture);
            funcionario.Imposto = double.Parse(Console.ReadLine()!);

            Console.WriteLine("Funcionário: " + funcionario);

            Console.Write("Digite a porcentagem para aumentar o salário: ");
            double porcentagem = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine("Dados atualizados: " + funcionario);
        }
    }

    public class Funcionario
    {
        public string? Nome;
        public double SalarioBruto, SalarioLiquido;
        public double Imposto;


        public double Liquido()
        {
            SalarioLiquido = SalarioBruto - Imposto;
            return SalarioLiquido;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto += SalarioBruto * porcentagem / 100.0;
        }

        public override string ToString()
        {
            return $"{Nome}, R$ {Liquido().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}