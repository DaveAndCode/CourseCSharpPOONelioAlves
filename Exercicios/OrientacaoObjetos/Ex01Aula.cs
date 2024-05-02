/*
Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais
velha.
Exemplo:
Dados da primeira pessoa:
Nome: Maria
Idade: 17

Dados da segunda pessoa:
Nome: Joao
Idade: 16

Pessoa mais velha: Maria
*/

namespace OrientacaoObjetos
{
    class Ex01Aula
    {
        public static void SolucaoExercicio()
        {
            Pessoa primeiraPessoa, segundaPessoa;
            primeiraPessoa = new Pessoa();
            segundaPessoa = new Pessoa();

            Console.WriteLine("Dados da primeira pessoa:");
            Console.Write("Nome: ");
            primeiraPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            primeiraPessoa.Idade = byte.Parse(Console.ReadLine()!);

            Console.WriteLine("Dados da segunda pessoa:");
            Console.Write("Nome: ");
            segundaPessoa.Nome = Console.ReadLine();
            Console.Write("Idade: ");
            segundaPessoa.Idade = byte.Parse(Console.ReadLine()!);

            if (primeiraPessoa.Idade > segundaPessoa.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.Nome}");
            }
            else
            {
                Console.WriteLine($"Pessoa mais velha: {segundaPessoa.Nome}");
            }
        }
    }

    public class Pessoa
    {
        public string? Nome;
        public byte Idade;
    }
}