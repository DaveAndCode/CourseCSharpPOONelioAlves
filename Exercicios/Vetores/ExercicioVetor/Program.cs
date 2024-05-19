namespace ExercicioVetor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented? ");
            int x = int.Parse(Console.ReadLine()!);

            Cliente[] clientes = new Cliente[10];

            for (int i = 0; i < x; i++)
            {
                Console.WriteLine($"Rent #{i+1}:");
                Console.Write("Name: ");
                string name = Console.ReadLine()!;

                Console.Write("Email: ");
                string email = Console.ReadLine()!;

                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine()!);

                System.Console.WriteLine();

                clientes[room] = new Cliente { Name = name, Email = email, Room = room};
            }

            Console.WriteLine("Busy rooms:");
            for (int i = 0; i < 10; i++)
            {
                if (clientes[i] != null )
                Console.WriteLine(clientes[i]);
            }
        }
    }
}