using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone Diana = new Phone("Zmitrevich", "Diana", "A.", "Upper str.", 4786, 1200, 300, 34, 0);
            Phone Yanis = new Phone("Zmitrevich", "Yanis", "A.", "Lower str.", 8635, 1344, 100, 34, 4);
            Phone Lauren = new Phone("Grennish", "Lauren", "D.", "Cap str.", 2964, 844, 250, 344, 20);
            Phone WarrenG = new Phone("G", "Warren", "P.", "Swag str.", 2694, 4000, 6000, 10, 100);
            Phone[] array = { Diana, Yanis, Lauren, WarrenG };
        }
    }
}
