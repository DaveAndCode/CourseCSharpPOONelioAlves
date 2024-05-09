namespace Properties
{
    class Produto
    {
         /*
             - Auto Properties
             - É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações get e set.

             public double Preco {get; private set;}
            */

        private string? _nome;
        public double Preco { get; private set; }  // Auto Properties
        public int Quantidade {get; private set; }  // Auto Properties

        public Produto()
        {

        }

        public Produto(string nome, double preco, int quantidade)
        {
            _nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }


        // Properties
        public string Nome
        {
            get { return _nome!;}

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }
    }
}