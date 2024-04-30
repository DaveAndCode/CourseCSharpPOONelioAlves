/**
* Leia 2 valores inteiros (A e B). Após, o programa deve mostrar uma mensagem "Sao Multiplos" ou "Nao sao
* Multiplos", indicando se os valores lidos são múltiplos entre si. Atenção: os números devem poder ser digitados em
* ordem crescente ou decrescente.
* Exemplos:
* Entrada:         Saída:
* 6 24         Sao Multiplos
* Entrada:         Saída:
* 6 25         Nao sao Multiplos
*/

namespace EstruturaCondicional
{
    class Ex02Aula
    {
        public static void Ex02AulaSolucao()
        {
            string[] valores = Console.ReadLine()!.Split(' ');
            int primeiroNumero = int.Parse(valores[0]);
            int segundoNumero = int.Parse(valores[1]);

            if (primeiroNumero > segundoNumero)
            {
                int calculo = primeiroNumero % segundoNumero;
                if (calculo == 0)
                {
                    Console.WriteLine($"{primeiroNumero} e {segundoNumero} São Múltiplos");
                }
                else
                {
                    Console.WriteLine($"{primeiroNumero} e {segundoNumero} Não são Múltiplos");
                }
            }
            else if (segundoNumero > primeiroNumero)
            {
                int calculo = segundoNumero % primeiroNumero;
                if (calculo == 0)
                {
                    Console.WriteLine($"{primeiroNumero} e {segundoNumero} São Múltiplos");
                }
                else
                {
                    Console.WriteLine($"{primeiroNumero} e {segundoNumero} Não são Múltiplos");
                }
            }
        }
    }
}