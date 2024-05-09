namespace PalavraThis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Palavra this
            /*
            - É uma referência para o próprio objeto

            - Uso comuns:
                - Diferenciar atributos de variáveis locais (Java)
                - Referenciar outro ocnstrutor em um construtor
                - Passar o próprio objeto como argumento na chamada de um método ou construtor
            */

            Produto produto = new Produto("TV", 900.0);
            Console.WriteLine(produto);
        }
    }
}