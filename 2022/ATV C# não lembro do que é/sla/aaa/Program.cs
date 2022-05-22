using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aaa
{
    internal class Program
    {
        static void Main(string[] args)
        {

           /*4- 
            int maior = 0, menor = 0, num;
            for(int i = 0; i <= 20; i++)
            {
                Console.WriteLine(i);
                num = int.Parse(Console.ReadLine());
                if (i == 1)
                {
                    maior = num;
                    menor = num;
                }
                if (num > maior)
                {
                    maior = num;
                }
                if (num < menor)
                {
                    menor = num;
                }
            }
            Console.WriteLine(menor);
            Console.WriteLine(maior);
            Console.ReadKey();*/




            /*3- 
            int ac = 0;
            for (int i = 0 ; i <= 10; i++  )
            {
                Console.Write("Digite um numero: ");
                int n = int.Parse(Console.ReadLine());
                if (n > 10)
                {
                    ac = ac + n;
                }   
            }
            Console.WriteLine(ac);

            Console.ReadKey();*/



            /*2- 
            inicio:
            Console.Write("Digite um numero: ");
            int n = int.Parse(Console.ReadLine());
            if (n > 0)
            {
                Console.WriteLine("Todos numeros inteiro entre um e " + n +" :");
                for (int i = 1; i <= n; i++)
                {
                    Console.WriteLine(i);
                }
            }
            else
            {
                Console.WriteLine("digite um numero acima de 0");
                goto inicio;
            }
            Console.ReadKey();*/





            /*1- 
            Console.Write("Digite um numero para montar sua Tabuada:");
            int num = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++)
            {
                Console.WriteLine("\n"+num + " X " + i + " = " + num * i);
            }
            Console.ReadKey();*/
        }
    }
}
