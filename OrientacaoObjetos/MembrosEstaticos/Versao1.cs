using System.Globalization;
namespace MembrosEstaticos
{
    class Versao1
    {
        static double Pi = 3.14;
        public static void Solucao()
        {
            Console.WriteLine("Entre o valor do raio: ");
            double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Circunferência: " + Circunferencia(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Volume: " + Volume(raio).ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Valro de PI: " + Pi.ToString("F2", CultureInfo.InvariantCulture));
        }

         static double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        static double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);  // Volume é igual a 4 terços vezes Pi vezes o raio ao cubo
        }
    }
}