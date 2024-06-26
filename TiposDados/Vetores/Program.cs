﻿using System.ComponentModel.Design;
using System.Globalization;
namespace Vetores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vetores
            /*
            - Em programação, "vetor" é o nome dado a arranjos unidimensionais

            - Arranjo é uma estrutura de dados:
                - Homogênea (dados do mesmo tipo)
                - Ordenada (elementos acessados por meio de posições)
                - Alocada de uma vez só, em um bloco contíguo de memória
            
            - Vantagens:
                - Acesso imediato aos elementos pela sua posição
            - Desvantagens:
                - Tamanho fixo
                - Dificuldade para se realizar inserções de deleções
            */

            // int n = int.Parse(Console.ReadLine()!);
            // double[] vect = new double[n];  // Instanciação e declaração do vetor

            // for (int i = 0; i < vect.Length; i++)
            // {
            //     vect[i] = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            // }

            // double sum = 0.0;
            // for (int i = 0; i < n; i++)
            // {
            //     sum += vect[i];
            // }

            // double avg = sum / n;  // Média

            // Console.WriteLine("AVERAGE HEIGHT = " + avg.ToString("F2", CultureInfo.InvariantCulture));
            
            // Vetores com objetos tipo referência.
            int n = int.Parse(Console.ReadLine()!);
            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                string name = Console.ReadLine()!;
                double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                vect[i] = new Product { Name = name, Price = price};
            }

            double sum = 0.0;

            for (int i = 0; i < n; i++)
            {
                sum += vect[i].Price;
            }
                double avg = sum / vect.Length;
                Console.WriteLine($"AVERAGE PRICE = {avg.ToString("F2", CultureInfo.InvariantCulture)} ");
        }
    }
}