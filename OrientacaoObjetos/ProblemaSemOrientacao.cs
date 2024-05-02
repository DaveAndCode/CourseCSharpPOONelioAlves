// Fazer um programa para ler as medidas dos lados de dois triângulos X e Y (suponha medidas
// válidas). Em seguida, mostrar o valor das áreas dos dois triângulos e dizer qual dos dois triângulos
// possui a maior área.
// A fórmula para calcular a área de um triângulo a partir das medidas de seus lados a, b e c é a
// seguinte (fórmula de Heron):
// area = raizQ de p( p - a)( p - b)( p - c)
// p = (a + b + c) / 2
using System.Globalization;
namespace OrientacaoObjetos
{
    class ProblemaSemOrientacao
    {
        public static void SolucaoDoExercicio()
        {
             double xA, xB, xC, p, areaX, yA, yB, yC, areaY, maiorArea;
            Console.WriteLine("Entre com as medidas do triângulo X: ");
            xA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            xB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            xC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            p = (xA + xB + xC) / 2;
            areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            yA = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            yB = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            yC = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            p = (yA + yB + yC) / 2;
            areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine("Área de X = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            maiorArea = Math.Max(areaX, areaY);
            if (maiorArea == areaX)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }
        }
    }
}