using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01Pag62
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double tnota = 0;
            double maior = int.MinValue;
            for(int alunos = 0; alunos < 16; alunos++) { 
                Console.WriteLine("Digite o sua nota:");
                double nota = double.Parse(Console.ReadLine());
                tnota =+ nota;
                alunos++;
                if (nota > maior) { 
                    maior = nota;
                }
                tnota = tnota / 15;
            }
            Console.WriteLine("Média da turma: " + tnota);
            Console.WriteLine("Maior nota: " + maior);
        }
    }
}
