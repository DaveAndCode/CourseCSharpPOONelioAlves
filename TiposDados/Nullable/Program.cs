namespace Nullable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Nullable
            /*
            - É um recurso de C# para que dados de tipo valor (structs) possam
            receber o valor null

            - Uso comum:
                - Campos de banco de dados que podem valer nulo (data de nascimento,
                algum valor numérico, etc.).
                - Dados e parâmetros opcionais.
            */

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());  // 0
            Console.WriteLine(y.GetValueOrDefault());  // 10

            Console.WriteLine(x.HasValue);  // False
            Console.WriteLine(y.HasValue);  // True

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("x is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("y is null");
            }

            // Operador de coalescência nula

            double? a = null;
            double b = a ?? 5.0;  // Se "a" não for nulo, receber o valor, se for
            // Então considere o valor 5
            Console.WriteLine(b);
        }
    }
}