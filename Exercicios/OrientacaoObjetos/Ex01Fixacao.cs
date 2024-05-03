/*
Fazer um programa para ler os valores da largura e altura
de um retângulo. Em seguida, msotrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe como mostrado no diagrama projeto do vídeo.

Exemplo:
Entre a largura e altura do retângulo:
3.00
4.00
AREA = 12.00
PERÍMETRO = 14.00
DIAGONAL = 5.00
*/

using System.Globalization;

namespace OrientacaoObjetos
{
    class Ex01Fixacao
    {
        public static void Solucao()
        {
            Retangulo retangulo = new();
            Console.WriteLine("Entre a largura e altura do retângulo: ");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.WriteLine(retangulo);
        }
    }

    public class Retangulo
    {
        public double Largura, Altura, Area, Perimetro, Diagonal;
        

        public double FindArea()
        {
            Area = Largura * Altura;
            return Area;
        }

        public double FindPerimetro()
        {
            Perimetro =  2 * (Largura + Altura);
            return Perimetro;
        }

        public double FindDiagonal()
        {
            Diagonal = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return Diagonal;
        }

        public override string ToString()
        {
            return @$"AREA = {FindArea().ToString("F2", CultureInfo.InvariantCulture)}
PERÍMETRO = {FindPerimetro().ToString("F2", CultureInfo.InvariantCulture)}
DIAGONAL = {FindDiagonal().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}