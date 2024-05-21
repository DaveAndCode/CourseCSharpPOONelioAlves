namespace Params
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = Calculator.Sum(5, 5, 5);
            double outraSoma = Calculator.Sum(5, 5, 10, 20);
            System.Console.WriteLine(soma);
            System.Console.WriteLine(outraSoma);
        }
    }
}