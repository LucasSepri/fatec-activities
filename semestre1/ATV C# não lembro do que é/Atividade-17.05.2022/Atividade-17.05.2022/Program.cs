using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_17._05._322
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*4 -) Faça um algoritmo que receba a quantidade de peças vendidas
                por vendedor e armazene essas quantidades em um vetor.
                Receba também o preço da peça vendida de cada vendedor e 
                armazene esses preços em outro vetor.Existem apenas dez vendedores e 
                cada vendedor pode vender apenas um tipo de peça, isto é, para cada 
                vendedor existe apenas um preço.Calcule e mostre a quantidade 
                total de peças vendidas por todos os vendedores e para cada vendedor 
                calcule e mostre o valor total da venda, isto é, a quantidade de peças* o preço da peça.*/

            /*3 -) Fazer um algoritmo que carregue dois vetores de dez elementos numéricos
                cada um e mostre um vetor resultante da intercalação desses dois vetores.
                Exemplo: ElementoVet1, ElementoVet2, ElementoVet1, ElementoVet2....ATÉ INTERCALAR OS DOIS VETORES. */


            /*2 -) Fazer um algoritmo que leia vários números inteiros positivos.
                A leitura se encerra quando encontrar um número negativo ou quando 
                o vetor ficar completo, sabe - se que o vetor possuiu, no máximo, 
                100 elementos.Gerar e imprimir o vetor onde cada elemento é o inverso ao vetor original. 
                Exemplo 10 será - 10... */

            int[] num = new int[5];
            int i = 0;
            for (i = 0; ; i++)
            {
                Console.WriteLine("Digite um Numero: ");
                num[i] = int.Parse(Console.ReadLine());


                if (i > 4) 
                {
                    break;
                }
                else if (num[i] < 0)
                {
                    break;
                }
                else
                {

                }

            }
            Console.ReadKey();
























            /*1 -) Fazer um algoritmo que armazene nomes, 
                notas das PE1 e PR2 de 3 alunos.Calcular e 
                armazenar a média, a situação do aluno: AP ou RP.
                Imprimir o nome, Notas, média e situação de cada aluno.*/

            /*string[] nome = new string[3];
            int[] PE1 = new int[3];
            int[] PR2 = new int[3];
            int[] Media = new int[3];
            string[] situacao = new string[3];

            int i;
            for(i = 0; i < 3; i++)
            {
                Console.WriteLine("Digite Digite seu nome:");
                nome[i] = Console.ReadLine();

                Console.WriteLine("Digite a nota da PE1:");
                PE1[i] = int.Parse(Console.ReadLine());

                Console.WriteLine("Digite a nota da PR2:");
                PR2[i] = int.Parse(Console.ReadLine());

                Media[i] = (PE1[i] + PR2[i]) / 2;

                if (Media[i] > 10)
                {
                    situacao[i] = "indefinido, coloque notas validas.";
                }
                else if (Media[i] >= 6)
                {
                    situacao[i] = "Aprovado";
                }
                else
                {
                    situacao[i] = "Reprovado";
                }
            }

            for(i = 1; i < 4; i++)
            {
                Console.WriteLine(i + "" + nome[i]);
                Console.WriteLine("Sua Nota da PE1: " + PE1[i] + "  Sua Nota da PR2: " + PR2[i]);
                Console.WriteLine("sua Media é: " + Media[i] + " Situação: " + situacao[i] + "\n");
            }

            Console.ReadKey();*/

        }
    }
}
