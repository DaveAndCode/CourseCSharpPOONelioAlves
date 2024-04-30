namespace Escopo
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * Escopo de uma variável: é a região do programa onde a variável é
            * válida, ou seja, onde ela pode ser referenciada.
            *
            * Uma variável não pode ser usada se não for iniciada.
            */

            int x;  // Foi declarada a variável, porém não inicializada
            // System.Console.WriteLine(x); Não seria possível usá-la
            x = 10;  // Foi inicializada
            System.Console.WriteLine(x);  // Agora é possível usá-la

            double preco = double.Parse(Console.ReadLine()!);
            double descontoGlobal = 0.0;

            if (preco > 100.0)
            {
                double desconto = preco * 0.1;  // Essa variável está no escopo da condição, só existe durante essa execução
                descontoGlobal = preco * 0.1;
            }

            // System.Console.WriteLine(desconto);  Não é possível acessar variáveis de escopos abaixo do método principal
            System.Console.WriteLine(descontoGlobal);  // Dependendo do valor de preco, aqui imprimirá 0.0 ou o cálculo executado dentro do if
        }
    }
}