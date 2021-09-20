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

            //строки
            string stroka1 = "hello ";
            string stroka2 = "world";
            string stroka3 = "!";
            Console.WriteLine(String.Compare(stroka1, stroka2));

            string stroka4 = String.Concat(stroka1, stroka2, stroka3); //соединение
            string stroka5 = String.Copy(stroka3); //копирование
            string[] strokas = stroka4.Split(' ');
            string stroka6 = stroka1.Insert(6, stroka2);
            string stroka7 = stroka1.Remove(4);

            string ss1 = " ";
            string ss2 = null;
            Console.WriteLine(String.Compare(ss1, ss2));

            StringBuilder ss3 = new StringBuilder("hello world!");
            ss3.Remove(0, 2);
            ss3 = ss3.Insert(0, "m");
            ss3 = ss3.Insert(ss3.Length, "ie");
        }
    }
}
