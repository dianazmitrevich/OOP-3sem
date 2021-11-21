using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    static class StatisticOperation
    {
        public static int Summa(this Set labaSet)
        {
            return labaSet.set.Sum();
        }

        public static int Difference(this Set labaSet)
        {
            return labaSet.set.Max() - labaSet.set.Min();
        }

        public static int Amount(this Set labaSet)
        {
            return labaSet.set.Length;
        }
    }
}
