using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex08Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];
            int[] vetor2 = new int[10];

            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("----------------------------");
                vetor[i] = r.Next(10);
                Console.WriteLine("Vetor 1: " + vetor[i]);
                vetor2[i] = r.Next(10);
                Console.WriteLine("Vetor 2: " + vetor2[i]);
                Console.WriteLine("----------------------------");
                Console.WriteLine("Soma dos dois vetores: " + (vetor[i] + vetor2[i]));
                Console.WriteLine("Diferença dos dois vetores: " + (vetor[i] - vetor2[i]));
            }
            Console.ReadKey();
        }
    }//Gabriel Fonseca 
}
