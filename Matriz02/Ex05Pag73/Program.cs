using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex05Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int[] vetor = new int [10];
            Random random = new Random();

            for (i = 0; i < vetor.Length; i++)
            {
                vetor[i] = random.Next(2);
                Console.WriteLine("----------------------");
                Console.WriteLine(vetor[i].ToString());
                Console.WriteLine("");

                if (vetor[i] == 0)
                {
                    Console.Write("0 na posição: ");
                    Console.WriteLine(i);
                    Console.WriteLine("");
                    Console.WriteLine("----------------------");
                }
            }
            Console.ReadKey();
        }
    }
}
