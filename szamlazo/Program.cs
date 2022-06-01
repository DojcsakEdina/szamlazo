using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using szamlazo.Models;

namespace szamlazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Szamla sz1 = new Szamla(5600);
            Console.WriteLine(sz1);
            Console.ReadKey();
        }
    }
}
