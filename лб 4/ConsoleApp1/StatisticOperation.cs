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

        // методы расширения
        // выделение первого числа, содержащегося в строке
        public static string FirstNum(this Set labaSet)
        {
            string result = "";
            result += labaSet.set[0];

            return result;
        }

        // удаление положительных элементов из множества
        public static string DeletePositiveNums(this Set labaSet)
        {
            string result = "";
            for (int i = 0; i < labaSet.set.Length; i++)
            {
                if (labaSet.set[i] < 0)
                {
                    result += labaSet.set[i];
                    result += " ";
                }
            }
            return result;
        }
    }
}
