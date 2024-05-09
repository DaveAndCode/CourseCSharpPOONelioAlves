namespace Properties
{
    class Program
    {
        static void Main(string[] args)
       {
            // Properties
            /*
            - São definições de métodos encapsulados, porém expondo uma sintaxe similar à de atributos e não de métodos.

            - Uma propriedade é um membro que oferece uma mecanismo flexível para ler, gravar ou calcular o valor de um campo particular, As propriedades podem ser usadas como se fossem atributos públicos, mas na verdade elas são métodos especiais chamados "acessadores". Isso permite que os dados sejam acessados facilmente e ainda ajudam a promover a segurança e a flexibilidade dos métodos.
            */

            Produto produto = new Produto("TV", 900.0, 10);

            produto.Nome = "TV 4K";  // Aqui usa-se a sintaxe de atributo, porém está sendo acesso com properties da classe.

            Console.WriteLine(produto.Preco.ToString("F2"));

            /*
             - Auto Properties
             - É uma forma simplificada de se declarar propriedades que não necessitam lógicas particulares para as operações get e set.

             public double Preco {get; private set;}
            */
       }
    }
}