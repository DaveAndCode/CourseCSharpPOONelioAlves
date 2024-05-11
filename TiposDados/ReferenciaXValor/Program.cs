namespace ReferenciaXValor
{
    class Program
    {
        static void Main(string[] args)
        {
            // Classes são tipos referência
            /*
            Variáveis cujo tipo são classes não devem ser entendidas como caixas,
            mas sim "tentáculos" (ponteiros) para caixas.
            */

            // Nesse momento, a variável está na memória stack
            Product produto, produto2;  // Não foi inicializada.

            // Nesse momento, ela foi inicializada e seu endereço está na memória Heap.
            produto = new Product("TV", 900.00, 0);  // O objeto "produto" é um ponteiro na Stack para a Heap.

            Console.WriteLine(produto.Name);  // TV

            produto2 = produto;  // Nesse momento, produto2 está apontando o mesmo endereço de produto, qualquer mudança em um, altera o outro (Não são cópias).
            
            Console.WriteLine(produto2.Name);  // TV
            produto.Name = "PC Gamer";

            Console.WriteLine(produto2.Name);  // PC GAMER
            
            // Structs são tipos valor
            /*
            A linguagem C# possui também tipos valor, que são os "structs". Structs são CAIXAS e não
            ponteiros.
            */

            // Foi declarado x e y na memória stack.
            double x, y;

            x = 10;  // X recebe o valor 10 na memória stack

            y = x;  // Y faz uma cópia de X na memória stack
            // Uma não interfere a outra.

            x = 20;

            Console.WriteLine(y);  // 10

            Point ponto;  // Foi declarada uma variável do tipo struct "Point"
            ponto.X = 10;
            ponto.Y = 20;
            Console.WriteLine(ponto);
        }
    }
}