using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex02Pag73
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[20];
            Random random = new Random();
            Console.Clear();
            Console.WriteLine("Números");
            Console.WriteLine("=================");

            for (int i = 0; i < numero.Length; i++)
            {
                numero[i] = random.Next(51, 100);
                Console.WriteLine(numero[i]);
            }

            Console.ReadKey();
        }
    }
}
