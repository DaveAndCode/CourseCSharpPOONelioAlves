using System.Globalization;
namespace MembrosEstaticos
{
    class Versao3
    {
        public static void Solucao()
        {
            Console.Write("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double circunferencia = CalculadoraEstatica.CalcularCircunferencia(raio);
            double volume = CalculadoraEstatica.CalcularVolume(raio);
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + CalculadoraEstatica.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
    class CalculadoraEstatica
    {
        public static double Pi = 3.14;

        public static double CalcularCircunferencia(double raio)
        {
            return 2.0 * Pi * raio;
        }

        public static double CalcularVolume(double raio)
        {
            return 4.0 / 3.0 * Pi * raio * raio * raio;
        }
    }
}