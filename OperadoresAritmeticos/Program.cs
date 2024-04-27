namespace OperadoresAritmeticos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores aritméticos
            /**
            * + | adição
            * - | subtração
            * * | multiplicação
            * / | divisão
            * % | módulo (resto da divisão)
            */

            int n1 = 3 + 4 * 2;  // Precedência da multiplicação é maior do que a soma, então será feito a mult depois a soma
            Console.WriteLine(n1);  // 11

            int n2 = (3 + 4) * 2;  // Precedência dos parênteses sobressai todas as outras, então primeiro é resolvido 3 + 4 e depois é multiplicado por 2
            Console.WriteLine(n2);  // 14

            int n3 = 17 % 3;  // Módulo da divisão (resto)
            Console.WriteLine(n3);  // 2

            double n4 = 10 / 8;  // 10 divido por 8 dá 1.25, porém o compilador observa os valores como int, então será truncado
            Console.WriteLine(n4);  // 1

            n4 = (double) 10 / 8;  // Agora aconteceu o casting, e retornará o valor com casas decimais
            Console.WriteLine(n4);  // 1.25

            double n5 = 10.0 / 8;  // Dessa forma também funciona, explicitando o .0 (O compilador vai entender que é double)
            Console.WriteLine(n5);  // 1.25

            // Cálculo equação do segundo grau
            double a = 1.0, b = -3.0, c = -4.0;  // Declaração de variáveis em apenas uma linha

            double delta = b * b - 4 * a * c;
            // double delta = Math.Pow(b, 2) - 4 * a * c;  // Dá pra usar essa função também para calcular a potência

            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

            Console.WriteLine("O delta é = " + delta.ToString("F2"));
            Console.WriteLine("O x1 é = " + x1.ToString("F2"));
            Console.WriteLine("O x2 é = " + x2.ToString("F2"));


        }
    }
}