namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            // Encapsulamento
            /*
            - É um princípio que consistem em esconder detalhes de implementação
            de um componente, expondo apenas operações seguras e que o matenha 
            em um estado consistente.

            - Regra de ouro: o objetivo deve sempre estar em um estado consisten
            te, e a própria classe deve garantir isso.
            */

            // Opção 1: implementação manual
            /*
            - Todo atributo é definido como private
            - Implementa-se métodos Get e Set para cada atributo, conforme regras de negócio

            - Nota: não é usual na plataforma C#
            */

            Produto produto = new Produto("TV", 900.00, 10);
            Console.WriteLine(produto.GetNome());  // Nome é "TV"

            produto.SetNome("Computador");  // Nome foi setado para "Computador"
            Console.WriteLine(produto.GetNome());

            produto.SetNome("A");  // O nome continua sendo "Computador", porque
            // no método foi colocado a lógica de aceitar somente se for maior
            // do que 1 caractere.
            // + Segurança de acordo com as regras do negócio.

            Console.WriteLine(produto.GetNome());

        }
    }
}