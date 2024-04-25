namespace RestricaoNomeVariavel
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Restrições para nomes de variáveis");

            Console.WriteLine("- Não pode começar com dígito: use uma letra ou _");
            Console.WriteLine("- Não usar acentos ou til");
            Console.WriteLine("- Não pode ter espaço em branco");
            Console.WriteLine("Sugestão: use nomes que tenham um significado");

            // Errado:
            /**
            * int 5minutos;
            * int salário;
            * int salario do funcionario;
            */

            // Correto:
            /**
            * int _5minutos;
            * int salario;
            * int salarioDoFuncionario;
            */

            // Convenções:
            /**
            * Camel Case: lastName (parâmetros de métodos, variáveis dentro de métodos)
            * Pascal Case: LastName (namespaces, classe, properties e métodos)
            * Padrão: _lastName (atributos "internos" da classe)
            */
        }
    }
}