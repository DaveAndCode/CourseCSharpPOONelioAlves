using System.Globalization;
namespace EntradaDeDados
{
    class Program
    {
        static void Main(string[] args)
        {
            // string? frase = Console.ReadLine();  // o interrogação ? que dizer que possivelmente é um nullable type
            // string? x = Console.ReadLine();
            // string? y = Console.ReadLine();
            // string? z = Console.ReadLine();
            // string[] vet = Console.ReadLine().Split(' ');  // Aqui foi declarado um vetor de strings (lista) que será separado os index por espaços
            // string? p1 = vet[0];
            // string? p2 = vet[1];
            // string? p3 = vet[2];


            // Console.WriteLine("Você digitou: ");
            // Console.WriteLine(frase);
            // Console.WriteLine(x);
            // Console.WriteLine(y);
            // Console.WriteLine(z);
            // Console.WriteLine(p1 + " " + p2 + " " + p3);

            // int n1 = int.Parse(Console.ReadLine()!);
            // // int n1 = Convert.ToInt32(Console.ReadLine());  // Usando esse método também é possível fazer a conversão

            // char ch = char.Parse(Console.ReadLine()!);  // Usando esse método também é possívelm fazer a conversão
            // // char ch = Convert.ToChar(Console.ReadLine()!);

            // double n2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);  // System.Globalization.CultureInfo.InvariantCulture (Vai considerar o ponto . no lugar da vírgula ,)

            // Console.WriteLine("Você digitou: ");
            // Console.WriteLine(n1);
            // Console.WriteLine(ch);
            // Console.WriteLine(n2.ToString("", CultureInfo.InvariantCulture));  // Exibe o ponto . no lugar da vírgula ,

            // string[] vet = Console.ReadLine()!.Split(' ');
            // string nome = vet[0];
            // char sexo = char.Parse(vet[1]);
            // byte idade = byte.Parse(vet[2]);
            // float altura = float.Parse(vet[3], CultureInfo.InvariantCulture);

            // Console.WriteLine("Você digitou: ");
            // Console.WriteLine(nome);
            // System.Console.WriteLine(sexo);
            // System.Console.WriteLine(idade);
            // System.Console.WriteLine(altura.ToString("", CultureInfo.InvariantCulture));

            Exercicio.SolucaoExercicio();

        }
    }
}