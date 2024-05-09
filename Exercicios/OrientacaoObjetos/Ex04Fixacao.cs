using System.Globalization;

namespace OrientacaoObjetos
{
    class Ex04Fixacao
    {
        public static void Solucao()
        {
            ContaBancaria conta;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine()!);

            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine()!;
            
            Console.Write("Haverá depósito inicial (s/n)?: ");
            char resposta = char.Parse(Console.ReadLine()!);

            if (resposta == 's' || resposta == 'S')
            {
                Console.Write("Digite o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
                conta = new ContaBancaria(titular, numero, depositoInicial);
            }
            else
            {
                conta = new ContaBancaria(titular, numero);
            }


            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            conta.Depositar(valor);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta);

            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            conta.Sacar(valor);

            Console.WriteLine("Dados da conta atualizados: ", System.Globalization.CultureInfo.InvariantCulture);
            Console.WriteLine(conta);
        }
    }

    class ContaBancaria
    {
        private double _taxaSaque = -5.00;
        public double Saldo { get; private set; }
        public int Numero { get; private set; }
        public string? Titular { get; set;}

        // Construtor com 2 parâmetros
        public ContaBancaria(string titular, int numero)
        {
            Titular = titular;
            Numero = numero;
        }


        // Construtor com 3 parâmetros, reaproveitando os valores do construtor acima
        public ContaBancaria(string titular, int numero, double saldo) : this(titular, numero)
        {
            Saldo = saldo;
        }


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && Saldo > valor)
            {
                Saldo -= valor - _taxaSaque;
            }
        }

        public override string ToString()
        {
            return "Conta "
            + Numero
            + ", Titular : "
            + Titular
            + ", Saldo: $"
            + Saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}