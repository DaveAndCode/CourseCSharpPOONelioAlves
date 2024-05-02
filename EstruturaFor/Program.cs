namespace EstruturaFor
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            for (início ; condição ; incremento)
            {
                comando 1
                comando 2
            }
            */
            Console.Write("Quantos números inteiros você vai digitar? ");
            int N = int.Parse(Console.ReadLine()!);
            int soma = 0;

            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine($"Valor: #{i}");
                int valor = int.Parse(Console.ReadLine()!);
                soma += valor;
            }

            System.Console.WriteLine("Soma = " + soma);
        }
    }
}