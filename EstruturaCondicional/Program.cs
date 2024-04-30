using System.ComponentModel;
using System.Net.WebSockets;

namespace EstruturaCondicional
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * Estrutura condicional
            * Simples:
            * if ( condição ) 
            * {
                comando 1
                comando 2
            * }
            *
            * Composta:
            * if ( condição )
            * {
                comando 1
                comando 2
            * } else {
                comando 3
                comando 4
            * }
            *
            * Encadeamentos:
             * if ( condição 1)
            * {
                comando 1
                comando 2
            * } else if ( condição 2) {
                comando 3
                comando 4
            * } else if ( condição 3) {
                comando 5
                comando 6
            * }
            * else
            * {
                 comando 8
                 comando 8
            * }
            */

            bool estaComFome = true;
            bool temComida = false;
            bool deveComer;

            if (estaComFome && temComida)
            {
                deveComer = true;
                Console.WriteLine("Você está com fome, e tem comida, então deve comer!");
                Console.WriteLine($"Deve comer? {deveComer}");
            }
            else if (estaComFome == false && temComida)
            {
                deveComer = false;
                Console.WriteLine("Você não está com fome mas tem comida, então não deve comer!");
                Console.WriteLine($"Deve comer? {deveComer}");
            }
            else if (estaComFome && temComida == false)
            {
                deveComer = false;
                Console.WriteLine("Você está com fome, porém não tem comida, então não dá pra comer!");
                Console.WriteLine($"Deve comer? {deveComer}");
            }
            else
            {
                deveComer = false;
                Console.WriteLine("Você não está com fome, e não tem comida, então não deve comer!");
                Console.WriteLine($"Deve comer? {deveComer}");
            }

            Console.WriteLine("Entre com um número inteiro: ");
            int numero = int.Parse(Console.ReadLine()!);
            if (numero % 2 == 0)
            {
                Console.WriteLine("Par!");
            }
            else
            {
                Console.WriteLine("Ímpar");
            }
            // else if (numero % 2 == 1)
            // {
            //     Console.WriteLine("Ímpar");
            // }
        }
    }
}