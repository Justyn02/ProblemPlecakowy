using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ProblemPlecakowy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę obiektów:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj seed:");
            int s = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj pojemność plecaka:");
            int c = int.Parse(Console.ReadLine());

            Problem problem = new Problem(n, s);
            Console.WriteLine(problem.ToString());

            Result wynik = problem.Solve(c);
            Console.WriteLine(wynik.ToString());
        }
    }
}
