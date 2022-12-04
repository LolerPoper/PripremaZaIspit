using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PripremaIspit_Trokut
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            programStart:
            Console.WriteLine("Upisite stranicu a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Upisite stranicu c: ");
            c = Convert.ToInt32(Console.ReadLine());

            if (a == 0 || b == 0 || c == 0)
            {
                Console.WriteLine("Stranica nema smisleni broj, pokusaj ponovo.");
                goto programStart;
            }
            else
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) Console.WriteLine("Dane stranice su stranice pravokutnog trokuta.");
                else Console.WriteLine("Dane stranice nisu stranice pravokutnog trokuta.");
            }
            Console.ReadKey();

        }
    }
}
