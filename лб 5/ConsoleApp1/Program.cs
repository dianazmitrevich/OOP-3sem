using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Film Scarface = new Film(170, 8, "Scarface", 7.9);
            Console.WriteLine(Scarface);

            Console.ReadKey();
        }
    }
}
