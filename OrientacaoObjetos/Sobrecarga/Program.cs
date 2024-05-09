using System.Globalization;
namespace Sobrecarga
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sobrecarga
            /*
            - É um recurso que uma classe possui de oferecer mais de uma operação com o mesm onome, porém com diferentes listas de parâmetros.
            */

            // Sintaxe alternativa para incializar valores
            Produto product = new Produto()  // No momento da instância do objeto "product"
            {
                Nome = "TV",
                Preco = 900.0,
                Quantidade = 0

            };

            Produto productNew = new Produto  // Isso funciona mesmo se a classe não possuir construtores implementados.
            {
                Nome = "Computador",
                Preco = 3600,
                Quantidade = 2
            };

            Console.WriteLine("Entre os dados do produto:");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Produto p = new(nome, preco);  // Agora na instanciação deverá ser passado os argumentos dos parâmetros declarados no construtor

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine()!);
            p.AdicionarProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
            Console.WriteLine();
            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine()!);
            p.RemoverProdutos(qte);
            Console.WriteLine();
            Console.WriteLine("Dados atualizados: " + p);
        }
    }
}