namespace ConversaoCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conversão implícita de tipos
            float x = 4.5f;

            double y = x;  // Naturalmente um float pode ser convertido em double, pois float tem 4 bytes, enquanto double possui 8 bytes (Cabe)

            Console.WriteLine(y);

            // Conversão explícita de tipos

            double a;
            float b;

            a = 5.1;
            // b = a;  // Aqui gerou um erro, porque a é do tipo double, e b é do tipo float (Um tipo maior em questão de memória não cabe em um menor)
            b = (float)a;  // Essa é a conversão explícita

            Console.WriteLine(b);

            double c;  // 8 bytes
            int d;
            c = 5.1;
            // int d = c;  // 4 Bytes (Também int não tem casas decimais, é literalmente um número inteiro)
            d = (int)c;  // Conversão explícita -> Valores decimais são truncados - > 5

            int e = 5;
            int f = 2;

            double resultado = e / f;  // Divisão inteira, porque E e F são int
            Console.WriteLine(resultado);  // --> 2

            resultado = (double) e / f;  // Casting de int para double
            Console.WriteLine(resultado);  // --> 2,5
        }
    }
}