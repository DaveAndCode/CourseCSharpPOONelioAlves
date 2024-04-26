using System.Globalization;
namespace SaidaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Bom dia!");  // WriteLine() adiciona uma quebra de linha no final da expressão
            Console.WriteLine("Boa tarde!");
            Console.WriteLine("Boa noite!");

            Console.WriteLine();

            Console.Write("Aqui está ");  // Write só escreve a expressão, sem acrescentar a quebra de linha.
            Console.Write("o meu ");
            Console.Write("texto.\n");  // É possível quebrar a linha acrescentando o caractere de escape "\n"

            Console.WriteLine();

            char genero = 'M';
            int idade = 22;
            double saldo = 10.35784;
            string nome = "David";

            Console.WriteLine(genero);
            Console.WriteLine(idade);
            Console.WriteLine(saldo.ToString("F2"));  // Formatando exibição com apenas 2 casas decimais
            System.Console.WriteLine($"{saldo:00.00}");  // Também formata para exibir com 2 casas decimais, usando interpolaton string
            Console.WriteLine(nome);

            Console.WriteLine();

            Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));  // Aqui vai exibir o "." no output no lugar de ","

            Console.WriteLine();

            // Placeholders
            Console.WriteLine("{0} tem {1} anos de idade e tem saldo igual a {2:F2} reais", nome, idade, saldo);

            // Interpolation Strings
            Console.WriteLine($"{nome} tem {idade} anos de idade e tem saldo igual a {saldo:F2} reais");

            // Concatenation
            Console.WriteLine(nome + " tem " + idade + " anos de idade e tem saldo igual a " + saldo.ToString("F2", CultureInfo.InvariantCulture) + " reais");
            */

            ExercicioFixacao.Exercicio();  // Chama o a execução do método ExercicioFixacao.Exercicio()
        }
    }
}