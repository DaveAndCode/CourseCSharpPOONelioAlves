using System.Globalization;
namespace PalavraThis
{
    class Produto
    {
        public string? Nome;
        public double Preco;
        public int Quantidade;

        // Construtor padrão
        public Produto()
        {
            Quantidade = 10;
        }

        public Produto(string nome, double preco) : this()  // Aqui está sendo referenciado o construtor paradrão
        {
            this.Nome = nome;
            this.Preco = preco;
            // A Quantidade será 10, mesmo não sendo informado aqui
        }

        // Aqui está sendo referenciado o construtor de 2 argumentos, receberá seu valor padrão.
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
        }

        public override string ToString()
        {
            return Nome
            + " "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + " "
            + Quantidade;
        }
    }
}