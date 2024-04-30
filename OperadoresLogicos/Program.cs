namespace OperadoresLogicos
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
            * && E (AND)
            * || OU (OR)
            * ! NÃO (NOT)
            * Precedência: ! > && > ||
            */

            bool comFome = true;  // Sim
            bool temComida = true;  // Sim
            bool comer = comFome && temComida;  // Comer se estiver com fome e haver comida - Sim
            Console.WriteLine($"Tá com fome? {comFome}, tem comida? {temComida}, então pode comer? {comer}");  // true

            Console.WriteLine("--------------------");

            bool temCarro = false;
            bool temMoto = true;
            bool podeViajar = temCarro || temMoto;  // temCarro OU temMoto
            Console.WriteLine($"Tem carro? {temCarro}, tem Moto {temMoto}, pode viajar? {podeViajar}");

            Console.WriteLine("-------------------");

            bool verdade = true;
            bool verdadeInversa = !verdade;  // Negação da verdade
            Console.WriteLine($"Verdade? {verdade}, qual o contrário de verdade? {verdadeInversa}");

            Console.WriteLine("-------------------");

            bool c1 = 2 > 3 || 4 != 5;  // true
            bool c2 = !(2 > 3) && 4 != 5;  // true
            bool c3 = 10 < 5;  // false
            bool c4 = c1 || c2 && c3;  // true
            Console.WriteLine(c4);
        }
    }
}