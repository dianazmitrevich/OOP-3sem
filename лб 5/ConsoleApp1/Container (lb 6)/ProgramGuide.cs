using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Container__lb_6_
{
    public class ProgramGuide
    {
        // Создать Программу передач.
        // Найти все фильмы, снятые в определенный год (с рейтингом более 5), подсчитать
        // продолжительность программы по времени, число
        // рекламных роликов.

        public object[] programArray;

        public ProgramGuide(params object[] array)
        {
            this.programArray = array;
        }

        public object this[int i]
        {
            get => programArray[i];
            set => programArray.Append(value);
        }

        public void add(object element)
        {
            this.programArray = programArray.Append(element).ToArray();
        }

        public void del(int number)
        {
            this.programArray = programArray.Where((e, i) => i != number).ToArray();
        }

        public void show()
        {
            for (int i = 0; i < this.programArray.Length; i++)
            {
                Console.WriteLine(this.programArray[i]);
            }
        }
    }
}
