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
            Console.WriteLine(produto);  // Por conta do método WriteLine, o C# já chamado o .ToString();
            
            Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine()!);
            produto.AdicionarProdutos(quantidade);

            Console.Clear();

            Console.WriteLine($"Dados atualizados: {produto}");

            Console.Write("Digite o número de produtos a ser removido do estoque: ");
            quantidade = int.Parse(Console.ReadLine()!);
            produto.RemoverProdutos(quantidade);

            Console.Clear();

            Console.WriteLine($"Dados atualizados: {produto}");
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

            // Sobrepondo um método
            public override string ToString()
            {
                return $"Dados do produto: {Nome}, R$ {Preco.ToString("F2", CultureInfo.InvariantCulture)}, {Quantidade} unidades, Total: R$ {ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture)}";
            }
        }
    }
}