namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            string? frase = Console.ReadLine();  // o interrogação ? que dizer que possivelmente é um nullable type
            string? x = Console.ReadLine();
            string? y = Console.ReadLine();
            string? z = Console.ReadLine();
            string[] vet = Console.ReadLine().Split(' ');  // Aqui foi declarado um vetor de strings (lista) que será separado os index por espaços
            string? p1 = vet[0];
            string? p2 = vet[1];
            string? p3 = vet[2];


            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1 + " " + p2 + " " + p3);
        }
    }
}