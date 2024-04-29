/**
* Faça um programa para ler dois valores inteiros, e depois mostrar na tela a soma desses números com uma
* mensagem explicativa, conforme exemplos.
* Exemplos:
Entrada: 
10
30
Saída:
SOMA = 40

Entrada: 
-30
10
Saída:
SOMA = -20

Entrada: 
0
0
Saída:
SOMA = 0
*/

namespace EstruturaSequencial
{
    class Ex01Aula
    {
        public static void Ex01AulaSolucao()
        {
            int primeiroNumero = int.Parse(Console.ReadLine()!);
            int segundoNumero = int.Parse(Console.ReadLine()!);
            int soma = primeiroNumero + segundoNumero;
            Console.WriteLine("SOMA = " + soma);
        }
    }
}