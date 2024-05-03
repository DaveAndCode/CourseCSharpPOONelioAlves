using System.Globalization;

namespace OrientacaoObjetos
{
    class ProblemaComOrientacao
    {
        public static void SolucaoDoExercicio()
        {
            Triangulo x, y;  // Declarando os objetos na memória stack que apontará para o endereço da memória heap (dinâmica)
            x = new Triangulo();  // Instanciando um objeto da classe Triangulo - heap (Está em algum lugar da memória RAM no momento de execução)
            y = new Triangulo();  // Instanciando outro objeto da classe Triangulo

            Console.WriteLine("Entre com as medidas do triângulo X: ");
            x.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y: ");
            y.A = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);

            double trianguloXArea = x.Area();
            double trianguloYArea = y.Area();

            Console.WriteLine("Área de X = " + trianguloXArea.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de Y = " + trianguloYArea.ToString("F4", CultureInfo.InvariantCulture));

            if (trianguloXArea > trianguloYArea)
            {
                Console.WriteLine("Maior área: X");
            }
            else
            {
                Console.WriteLine("Maior área: Y");
            }

        }
    }

    public class Triangulo  // Criando a classe Triangulo
    {
        // Atributos
        public double A, B, C, P, AreaFinal;

        // Métodos
        public double Area()
        {
            P = (A + B + C) / 2;
            AreaFinal = Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            return AreaFinal;
        }
    }
}