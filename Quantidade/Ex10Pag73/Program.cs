using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex10Pag73
{
    internal class Program

    {
        static void Main(string[] args)
        {
            int[] salario = {250, 350, 450, 550, 700, 900, 1300};
            int[] quant = {0, 0, 0, 0, 0, 0, 0};
            string nome = "";

            while(true)
            {
                Console.WriteLine("------------------------------ \n");
                Console.WriteLine("Digite 'sair' para sair \n");
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();
                if(nome == "sair") 
                    break;
                Console.WriteLine("");
                Console.Write("Qual sua classe: ");
                int x = int.Parse(Console.ReadLine());
                quant[x - 1] ++;
                x = salario[x - 1];
                Console.WriteLine("------------------------------ \n");
                Console.WriteLine($"Funcionário {nome} Salário R$ {x},00 \n");
            }
            
            Console.Clear();
            
            for(int i = 0; i < quant.Length; i++)
            {
                Console.WriteLine("------------------------------ \n");
                Console.WriteLine($"Funcionários classe {i + 1}: {quant[i]} \n");
            }
                Console.WriteLine("------------------------------ \n");
                Console.WriteLine($"Classe com mais funcionários: {quant.Max()}");
            Console.ReadKey();
        }
    }
}
