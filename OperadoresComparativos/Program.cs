namespace OperadoresComparativos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * Operadores comparativos
            * > maior
            * < menor
            * >= maior ou igual
            * <= menor ou igual
            * == igual
            * != diferente
            */

            int a = 10;
            bool c1 = a < 10;  // false
            bool c2 = a < 20;  // true
            bool c3 = a > 10;  // false
            bool c4 = a > 5;  // true
            
            Console.WriteLine(c1);
            Console.WriteLine(c2);
            Console.WriteLine(c3);
            Console.WriteLine(c4);

            Console.WriteLine("----------------------");

            bool c5 = a <= 10;  // true
            bool c6 = a >= 10;  // true
            bool c7 = a == 10;  // true
            bool c8 = a != 10;  // false
            Console.WriteLine(c5);
            Console.WriteLine(c6);
            Console.WriteLine(c7);
            Console.WriteLine(c8);
        }
    }
}