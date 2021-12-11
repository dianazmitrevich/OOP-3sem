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
            Set<int> newSet = new Set<int>(new[] { 1, 2, 3 });
            
            newSet.Show();
            Console.WriteLine();
            newSet.Add(4);
            newSet.Show();
            Console.WriteLine();
            newSet.Del(0);
            newSet.Show();

            Set<double> newSetDouble = new Set<double>(new[] { 1.4, 2.5, 3.6 });

            Console.WriteLine("\n");
            newSetDouble.Show();
            Console.WriteLine();
            newSetDouble.Add(4.7);
            newSetDouble.Show();
            Console.WriteLine();
            newSetDouble.Del(1);
            newSetDouble.Show();

            Set<TelevisionProgram> newSetClass = new Set<TelevisionProgram>(new TelevisionProgram[] { new TelevisionProgram(24, 12), new TelevisionProgram(128, 6) });

            Console.WriteLine("\n");
            newSetClass.Show();
            Console.WriteLine();
            newSetClass.Add(new TelevisionProgram(225, 8));
            newSetClass.Show();
            Console.WriteLine();
            newSetClass.Del(0);
            newSetClass.Show();

            Console.ReadKey();
        }
    }
}
