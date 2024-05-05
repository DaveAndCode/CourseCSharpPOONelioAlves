using System.Globalization;
namespace MembrosEstaticos
{
    class Versao2
    {
        public static void Solucao()
        {

            Calculadora calculadora = new Calculadora();
            Console.Write("Digite o raio: ");
            double raio = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            double circunferencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);
            Console.WriteLine("Circunferência: " + circunferencia.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Circunferência: " + volume.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("PI: " + calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture));
        }
    }

    class Calculadora
    {
        public double Pi = 3.14;


        public double Circunferencia(double r)
        {
            return 2 * Pi * r;
        }

        public double Volume(double r)
        {
            return 4.0 / 3.0 * Pi * Math.Pow(r, 3.0);  // Volume é igual a 4 terços vezes Pi vezes o raio ao cubo
        }
    }
}
