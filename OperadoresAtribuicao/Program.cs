namespace OperadoresAtribuicao
{
    class Program
    {
        static void Main(string[] args)
        {
            // Operadores de atribuição

            int a = 10;  // "=" atribui o valor
            a += 2;  // "+=" acrescenta o valor
            System.Console.WriteLine(a);  // 12

            a -= 2;  // "-=" decrescenta o valor
            System.Console.WriteLine(a);  // 10

            a *= 2; // "*=" multiplica o valor
            System.Console.WriteLine(a);  // 20

            a /= 2;  // "/=" divide o valor
            System.Console.WriteLine(a);  // 10

            a %= 3;  // "%=" a recebe o módulo de a módulo 3 (Resto da divisão)
            System.Console.WriteLine(a);  // 1

            string letras = "ABC";
            letras += "DEF";
            System.Console.WriteLine(letras);  // "ABCDEF"

            int b = 10;
            b++;  // b incrementou + 1
            System.Console.WriteLine(b);  // 11

            b--; // b decrementou - 1
            System.Console.WriteLine(b);  // 10
        }
    }
}