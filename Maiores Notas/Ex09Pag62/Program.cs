using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex09Pag62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maior = int.MinValue;
            int maior2 = int.MinValue;
            int maiorr = 0;
            int maiorr2 = 0;
            for (int alunos = 0; alunos != 10; alunos++) {
                Console.WriteLine("Informações do aluno");
                Console.WriteLine("--------------------");
                Console.Write("Digite sua matricula: ");
                int matricula = int.Parse(Console.ReadLine());
                Console.Write("Digite sua nota: ");
                int nota = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("--------------------");
                Console.WriteLine("");

                if (maior < nota)
                {
                    maior = nota;
                    maiorr = matricula;
                }
                else if (maior2 < nota) 
                { 
                    maior2 = nota;
                    maiorr2 = matricula;    
                }
            }
            Console.WriteLine("Maior nota é " + maior + " da matricula " + maiorr);
            Console.WriteLine("Segunda maior nota é " + maior2 + " da matricula " + maiorr2);
            Console.ReadKey();
        }
    }
}

// Gabriel Fonseca - rua dos bobos, bairro Santa Cruz
