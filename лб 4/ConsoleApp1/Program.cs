﻿using System;
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
            Set labaSet1 = new Set(new[] { 6, 1, 24, 0, 5 });
            Set labaSet2 = new Set(new[] { 999, 1, 24, 4, 8 });

            Console.WriteLine("> - проверка на принадлежность = {0}", labaSet1 > 5);
            Console.WriteLine("* - пересечение множеств = {0}", labaSet2 * labaSet2);

            var result = labaSet1.set.Intersect(labaSet2.set);
            foreach (int s in result)
                Console.Write(s + " ");

            Console.WriteLine("\n< - проверка на подмножество = {0}", labaSet1 < labaSet2);

            Console.ReadKey();
        }
    }
}
