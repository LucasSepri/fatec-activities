using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade12_31_05_22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 5.Faça um algoritmo para ler 15 números e 
            armazenar em um vetor VET, colocar o vetor 
            em ordem crescente e decrescente.*/



            /*int[] V = new int[15];

            for(int i = 1; i < 16; i++)
            {
                Console.Write("Digite o "+i+"º Número: ");
                V[i-1] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nNúmeros em ordem Crescente");
            Array.Sort(V);
            for(int i = 0; i < V.Length; i++)
            {              
                Console.WriteLine(V[i]);
            }

            Console.WriteLine("\nNúmeros em ordem Decrescente");
            Array.Reverse(V);
            for (int i = 0; i < V.Length; i++)
            {   
                Console.WriteLine(V[i]);
            }

            Console.ReadKey(); */
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            /*4.Ler um vetor Q de 20 posições(aceitar somente
            números positivos).Escrever a seguir o valor do 
            maior elemento de Q e a respectiva posição que 
            ele ocupa no vetor.*/


            /*int[] Q = new int[5];
            int N;
            int maior = 0;
            int pos = 0;
            

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite um numero: ");
                inicio:
                N = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    maior = N;
                    
                }
                if (N > maior)
                {
                    maior = N;
                    pos = pos + 1;
                }
                if(N >= 0)
                {
                    Q[i] = N;
                }
                else
                {
                    Console.WriteLine("Numero negativo, Digite Novamente:");
                    goto inicio;
                }
            }
            Console.WriteLine("Maior número: " + maior+" Posição: "+pos);
          
            Console.ReadKey();*/









            /*3.Escreva um algoritmo que permita a leitura
            dos nomes de 10 pessoas e armazene os nomes 
            lidos em um vetor.Após isto, o algoritmo deve 
            permitir a leitura de mais 1 nome qualquer de 
            pessoa e depois escrever a mensagem ACHEI, se 
            o nome estiver entre os 10 nomes lidos 
            anteriormente(guardados no vetor), ou NÃO ACHEI 
            caso contrário.*/

            /*string[] nomes = new string[30];
            string nome;
            string exibir = "";
            for (int i = 0; i < 10; i++) 
            {
                Console.WriteLine("Escreva o nome do aluno: ");
                nomes[i] = Console.ReadLine();
            }
            Console.WriteLine("Escreva mais um nome: ");
            nome = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                if (nomes[i] == nome)
                {
                    exibir = "ACHEI";
                    break;
                }
                else
                {
                    exibir = "NÃO ACHEI";
                }
            }
            Console.WriteLine(exibir);
            Console.ReadKey();*/







            /*2.Faça um programa que leia 20 valores no vetor 
            e no final, escreva o maior e o menor valor lido.*/

            /*int[] V1 = new int[20];
            int M = 0;
            int m = 0;

            int i;

            for (i = 0; i < 20; i++)
            {
                V1[i] = int.Parse(Console.ReadLine());

                if(M == 0)
                {
                    M = V1[i];
                }
                if (V1[i] > M)
                {
                    M = V1[i];
                }
                if (V1[i] < M)
                {
                    m = V1[i];
                }
            }
            Console.WriteLine("maior valor: ");
            Console.WriteLine(M);
            Console.WriteLine("menor valor: ");
            Console.WriteLine(m);
            Console.ReadKey();*/


            /*1-Elabore um programa que permita a digitação
            de 3 vetores com 5 posições, um contendo o nome, 
            o segundo contendo a primeira nota e o terceiro 
            contendo a segunda nota. Logo após as entradas 
            mostrar na tela o nome, as notas e a média aritmética 
            destas duas notas.*/

            /*string[] V1 = new string[5];
            int[] V2 = new int[5];
            int[] V3 = new int[5];
            int[] V4 = new int[5];

            int i;

            for (i = 0; i < 5; i++)
            {
                V1[i] = Console.ReadLine();
                V2[i] = int.Parse(Console.ReadLine());
                V3[i] = int.Parse(Console.ReadLine());

                V4[i] = (V2[i] + V3[i])/2;

                Console.WriteLine(V1[i]);
                Console.WriteLine(V2[i]);
                Console.WriteLine(V3[i]);
                Console.WriteLine(V4[i]);
            }
            Console.ReadKey();*/
        }
    }
}
