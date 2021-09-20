using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project {
    class Program {
        static void Main(string[] args) {
            // типы
            bool isEven = true;
            byte n1 = 24;
            sbyte n2 = -25;
            short n3 = -25;
            ushort n4 = 26;
            int n5 = 7;
            uint n6 = 28;
            long n7 = -29;
            ulong n8 = 30;
            float n9 = 31;
            double n10 = 3.2;
            char s1 = 's';
            string s2 = "symbol";
            object abc = 'a';

            //явное преобразование
            short p1 = (short)n5; //преобразование в 16-битное целое
            int p2 = (int)n9; //преобразование в целое число
            float p3 = (float)n10;
            uint p4 = (uint)n5;
            char p5 = (char)n5;

            //неявное преобразование
            long p6 = n5;
            float p7 = n5;
            double p8 = n5;
            long p9 = n3;
            float p10 = n6;

            //распаковка и упаковка
            object j1 = n5; //упаковка int в object
            int j2 = (int)j1; //распаковка к исходному типу значения

            //неявно типизированная переменная
            var peremennaya = "hello world"; //эквивалентно string peremennaya ...

            //nullable переменная
            int? nn = null; //используется для работы, если мы не знаем имеет ли значение
            if (nn.HasValue)
                Console.WriteLine(nn.Value);
            else
                Console.WriteLine("nn is equal to null");
        }
    }
}
