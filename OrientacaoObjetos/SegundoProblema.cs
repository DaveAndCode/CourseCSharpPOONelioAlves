using System.Globalization;
namespace OrientacaoObjetos
{
    class SegundoProblema
    {
        public static void Solucao()
        {
            Produto produto = new();
            Console.WriteLine("Entre os dados do produto: ");
            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine()!;
            Console.Write("Preço: ");
            produto.Preco = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = int.Parse(Console.ReadLine()!);
            
            Console.Clear();

            Console.WriteLine($"Dados do produto: {produto.Nome}, R$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produto.Quantidade} unidades, Total: R$ {produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);
            produto.AdicionarProdutos(quantidade);

            Console.Clear();

            Console.WriteLine($"Dados atualizados: {produto.Nome}, R$ {produto.Preco.ToString("F2", CultureInfo.InvariantCulture)}, {produto.Quantidade} unidades, Total: R$ {produto.ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine()!);
            produto.RemoverProdutos(quantidade);

            Console.Clear();

            Console.WriteLine($"Dados atualizados: {produto.Nome}, R$ {produto.Preco}, {produto.Quantidade} unidades, Total: R$ {produto.ValorTotalEmEstoque()}");
            
        }
        public class Produto
        {
            public string? Nome;
            public double Preco;
            public int Quantidade;


            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }

            public void AdicionarProdutos(int quantity)
            {
                Quantidade += quantity;
            }

            public void RemoverProdutos(int quantity)
            {
                Quantidade -= quantity;
            }
        }
    }
}