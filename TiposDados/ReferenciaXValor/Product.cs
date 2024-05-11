namespace ReferenciaXValor
{
    class Product
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }


        // Constructor
        public Product(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }
    }
}