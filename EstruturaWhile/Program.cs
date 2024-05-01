using System.Globalization;
namespace EstruturaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double numero = double.Parse(Console.ReadLine()!);

            while (numero >= 0)
            {
                double raizQ = Math.Sqrt(numero);
                Console.WriteLine(raizQ.ToString("F3", CultureInfo.InvariantCulture));
                Console.Write("Digite outro número: ");
                numero = double.Parse(Console.ReadLine()!);
            }

            Console.WriteLine("Número negativo!");
            
        }
    }
}