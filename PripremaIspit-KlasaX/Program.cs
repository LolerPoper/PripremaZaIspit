using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PripremaIspit_KlasaX
{
    static class KlasaX
    {
        static private int broj;

        static public int Broj { get => broj; set => broj = value; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            KlasaX.Broj = 10;

            Console.WriteLine(Convert.ToString(KlasaX.Broj));

            Console.ReadKey();

        }
    }
}
