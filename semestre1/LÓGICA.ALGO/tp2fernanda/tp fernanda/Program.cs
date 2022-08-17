using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_fernanda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 3-) Uma empresa XXX tem registros numa matriz consumo, 
            os consumos mensais de energia elétrica dos anos 1990-1999.
            Cada linha representa um ANO e cada coluna representa um mês.
            Considerando esses dados, fazer um pseudocódigo e
            fluxograma que imprima:  */

            //a-) o consumo médio em cada um dos meses destes dez anos;
            //b-) o mês/ano em que a empresa gastou mais energia nestes dez anos. 

            /*int[,] C = new int[10, 12];// consumo médio

            int i, j, k, l=0;//variavel de ação 
            
            int a = 2;//valor ano
            
            int m = 2;//valor mes



            int aa = 0;

            int mm = 0;

            for (i = 0; i < a; i++)//anos
            {
                Console.WriteLine("Ano: " + (1990 + i));
                for (j = 0; j < m; j++)//meses
                {
                    Console.WriteLine("Digite o consumo mensal " + (j + 1) + "º do mês: ");
                    k = int.Parse(Console.ReadLine());

                    if (l < k)
                    {
                        l = k;
                        aa = i;
                        mm = j;
                    }

                    k = k / 30;//cada mês
                    C[i, j] = k;

                }
            }


            //ETAPA A
            Console.WriteLine("o consumo médio em cada um dos meses destes dez anos: ");
            for (i = 0; i < a; i++)
            {
                Console.WriteLine("Ano: " + (1990 + i));
                for (j = 0; j < m; j++)//meses
                {
                    Console.WriteLine((j + 1) + "º mês: ");
                    Console.WriteLine(C[i, j]);
                }
            }


            //ETAPA B
            Console.WriteLine("O mês/ano em que a empresa gastou mais energia nestes dez anos: ");
            Console.WriteLine("ano: " + aa);
            Console.WriteLine("mes: " + mm);


            Console.ReadKey();*/
        }
    }
}
