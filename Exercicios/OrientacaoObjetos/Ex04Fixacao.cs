namespace OrientacaoObjetos
{
    class Ex04Fixacao
    {
        public static void Solucao()
        {
            Conta conta01 = new Conta();

            Console.Write("Entre o número da conta: ");
            conta01.ContaId = int.Parse(Console.ReadLine()!);

            Console.Write("Entre o titular da conta: ");
            conta01.NomeTitular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicial = char.Parse(Console.ReadLine()!);

            if (depositoInicial.ToString() == "s")
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double valorDepositoInicial = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
                conta01.Depositar(valorDepositoInicial);
            }

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(conta01);

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            conta01.Depositar(valorDeposito);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta01);
            
            Console.Write("Entre um valor para saque: ");
            double valorSaque = double.Parse(Console.ReadLine()!, System.Globalization.CultureInfo.InvariantCulture);
            conta01.Sacar(valorSaque);

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(conta01);

        }
    }

    class Conta
    {
        private double _saldo;
        private double _taxaSaque = -5.00;
        public int ContaId { get; set; }
        public string? NomeTitular { get; set;}

        public Conta()
        {

        }


        public void Depositar(double valor)
        {
            if (valor > 0)
            {
                _saldo += valor;
            }
        }

        public void Sacar(double valor)
        {
            if (valor > 0 && _saldo > valor)
            {
                _saldo -= valor - _taxaSaque;
            }
        }

        public override string ToString()
        {
            return "Conta "
            + ContaId
            + ", "
            + "Titular : "
            + NomeTitular
            + ", "
            + "Saldo: $"
            + _saldo.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
        }
    }
}