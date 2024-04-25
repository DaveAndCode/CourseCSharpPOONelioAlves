namespace TiposDados
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tipos de Dados");

            sbyte variavelBytecomSinal = -127;  // Armazena 1 byte, vai de -128 a 127 (256 combinações possíveis) - Aceita números negativos
            Console.WriteLine(variavelBytecomSinal + " - sbyte");

            byte variavelByte = 255;  // Armazena 1 byte, vai de 0 a 255 ( 256 combinações possíveis) - Não aceita números negativos
            Console.WriteLine(variavelByte + " - byte");

            byte overflow = 255;
            overflow++;  // Incrementou +1 = 256 (Passou do limite suportado pelo tipo byte)
            Console.WriteLine(overflow);  // Retorna o inverso, 256 é o máximo, então retorna 0 que é o mínimo

            sbyte overflowNegativo = 127;
            overflowNegativo++;  // Incrementou +1 = 128 (Passou do limite suportado pelo tipo sbyte)
            Console.WriteLine(overflowNegativo);  // Retorna o inverso, 127 é o máximo, então retorna -128 que é o mínimo

            byte n1 = 255;  // Valor máximo para byte
            int n2 = 2147483647;  // Valor máximo para int
            long n3 = 2147483648L;  // Boa prática colocar o sufixo "L" em números long

            Console.WriteLine("Inteiro tipo byte = " + n1);
            Console.WriteLine("Inteiro tipo int " + n2);
            Console.WriteLine("Inteiro tipo long" + n3);
        }
    }
}