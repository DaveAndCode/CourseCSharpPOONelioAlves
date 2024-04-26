using System.Globalization;
namespace SaidaDeDados
{
    class ExercicioFixacao
    {
        public static void Exercicio()
        {
            /**
            * Em um novo programa, inicie as seguintes variáveis:
            * string produto1 = "Computador";
            * double preco1 = 2100.0;
            *
            * string produto2 = "Mesa de escritório";
            * double preco2 = 650.50;
            *
            * double medida = 53.234567;
            *
            * byte idade = 22;
            * int codigo = 5290;
            * char genero = 'M';
            *
            * Output:
            *
            * Produtos:
            * Computador, cujo preço é $ 2100,00
            * Mesa de escritório, cujo preço é $ 650,50
            * 
            * Registro: 22 anos de idade, código 5290 e gênero: M
            *
            * Medida com oito casas decimais: 53,23456700
            * Arredondando (três casas decimais): 53,235
            * Separador decimal invariant culture: 53.235
            */

            string produto1 = "Computador";
            double preco1 = 2100.0;

            string produto2 = "Mesa de escritório";
            double preco2 = 650.50;

            double medida = 53.234567;

            byte idade = 22;
            int codigo = 5290;
            char genero = 'M';

            Console.WriteLine(@$"Produtos:
{produto1}, cujo preço é $ {preco1:F2}
{produto2}, cujo preço é $ {preco2:F2}

Registro: {idade} anos de idade, código {codigo} e gênero: {genero}

Medida com oito casas decimais: {medida:F8}
Arredondando (três casas decimais): {medida:F3}
Separador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}