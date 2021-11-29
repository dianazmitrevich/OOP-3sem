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
            Film Scarface = new Film(170, 8, "Scarface", 8.7);
            News WorkPlace = new News(5, 8, "Employment");
            Ad IPhone13Promotion = new Ad(3, 8, "Mobile phones");

            Printer printer = new Printer();
            printer.IAmPrinting(Scarface);

            Console.ReadKey();
        }
    }
}
