using NegyzetNevter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Negyzet
{
    internal class Futtathato
    {
        static void Main(string[] args)
        {
            Negyzet negyzet = new Negyzet(3);

            Console.WriteLine("Négyzet átjója:");
            //Console.WriteLine(negyzet.Atlo);
            Console.WriteLine($"{negyzet.Atlo:n3}");

            Console.WriteLine();
            Console.WriteLine("Kocka térfogata:");
            Console.WriteLine(negyzet.TeglatestTerfogata(5));
        }
    }
}
