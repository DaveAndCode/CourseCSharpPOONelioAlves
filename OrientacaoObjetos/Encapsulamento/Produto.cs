namespace Encapsulamento
{
    class Produto
    {
        // Attributes

        // Por convenção no C#, utiliza-se a seguinte nomenclatura de atributos
        // privados:
        private string? _nome;
        private double _preco;
        private int _quantidade;

        // Constructors
        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            _preco = preco;
        }

        // Get and Set Methods
        public string GetNome()
        {
            return _nome;
        }


        // Vantagem de acessar atributos por métodos, é impor lógica na chamada
        // Aqui só aceitará o valor, se ele não for nulo e o nome for maior do que
        // 1 caractere:
        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1)
            {
                _nome = nome;
            }
        }


        public double GetPreco()
        {
            return _preco;
        }

        public int GetQuantidade()
        {
            return _quantidade;
        }


        // Other methods
        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

    }
}