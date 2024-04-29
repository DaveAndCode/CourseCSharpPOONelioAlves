/**
* Fazer um programa que leia três valores com ponto flutuante de dupla precisão: A, B e C. Em seguida, calcule e
* mostre:
* a) a área do triângulo retângulo que tem A por base e C por altura.
* b) a área do círculo de raio C. (pi = 3.14159)
* c) a área do trapézio que tem A e B por bases e C por altura.
* d) a área do quadrado que tem lado B.
* e) a área do retângulo que tem lados A e B.
* Exemplos:
Entrada:           Saída:
3.0 4.0 5.2   TRIANGULO: 7.800
              CIRCULO: 84.949
              TRAPEZIO: 18.200
              QUADRADO: 16.000
              RETANGULO: 12.000
*/
using System.Globalization;
namespace EstruturaSequencial
{
    class Ex06Aula
    {
        public static void Ex06AulaSolucao()
        {
            string[] valores = Console.ReadLine()!.Split(' ');
            double valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);
            double areaTriangulo = valorA * valorC / 2;
            double areaCirculo = 3.14159 * (valorC * valorC);
            double areaTrapezio = 0.5 * valorC * (valorA + valorB);
            double areaQuadrado = valorB * valorB;
            double areaRetangulo = valorA * valorB;

            Console.WriteLine("TRIANGULO: " + areaTriangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + areaCirculo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + areaTrapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + areaQuadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + areaRetangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}