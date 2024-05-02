/*
Um Posto de combustíveis deseja determinar qual de seus produtos tem a preferência de seus clientes. Escreva
um algoritmo para ler o tipo de combustível abastecido (codificado da seguinte forma: 1.Álcool 2.Gasolina 3.Diesel
4.Fim). Caso o usuário informe um código inválido (fora da faixa de 1 a 4) deve ser solicitado um novo código (até
que seja válido). O programa será encerrado quando o código informado for o número 4. Deve ser escrito a
mensagem: "MUITO OBRIGADO" e a quantidade de clientes que abasteceram cada tipo de combustível, conforme
exemplo.
Exemplo:
Entrada:         Saída:
8               MUITO OBRIGADO
1               Alcool: 1
7               Gasolina: 2
2               Diesel: 0
2
4
*/

namespace EstruturaWhile
{
    class Ex03Aula
    {
        public static void Ex03AulaSolucao()
        {
            int alcool = 0;
            int gasolina = 0;
            int diesel = 0;
            bool looping = true;

            while (looping)
            {
                Console.WriteLine("### Qual o seu combustível favorito senhor(a) cliente? ###");
                Console.WriteLine("[1] - Álcool");
                Console.WriteLine("[2] - Gasolina");
                Console.WriteLine("[3] - Diesel");
                Console.WriteLine("[4] - Fechar programa");
                Console.Write(":");
                int opcao = int.Parse(Console.ReadLine()!);
                
                if (opcao == 1)
                {
                    alcool++;
                    Console.Clear();
                }
                else if (opcao == 2)
                {
                    gasolina++;
                    Console.Clear();
                }
                else if (opcao == 3)
                {
                    diesel++;
                    Console.Clear();
                }
                else if (opcao == 4)
                {
                    Console.Clear();
                    looping = false;
                    break;
                }
                
                else
                {
                    Console.Clear();
                    Console.WriteLine("Valor informado errado, tente novamente: ");
                    continue;
                }

                Console.WriteLine(@$"MUITO OBRIGADO
Alcool: {alcool}
Gasolina: {gasolina}
Diesel: {diesel}");
            }
        }
    }
}