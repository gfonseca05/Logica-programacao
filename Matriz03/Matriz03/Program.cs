using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matriz03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[4, 6];
            int[] coluna = new int[6];
            Random n = new Random();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                Console.WriteLine("");
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write($" {matriz[i, j] = n.Next(10)} ");
                    coluna[i] += matriz[j, i];
                    Console.Write($"(SOMA = {coluna[i]})");
                }
            }


            Console.ReadKey();
        }
    }
}
