using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Set
    {
        // Вариант 8
        // Класс - множество Set. Дополнительно перегрузить
        // следующие операции: > - проверка на принадлежность (типа
        // операции in множественного типа), * - пересечение множеств,
        // < - проверка на подмножество

        // Методы расширения:
        // 1) Выделение первого числа, содержащегося в строке
        // 2) Удаление положительных элементов из множества

        public int[] set;
        private IEnumerable<int> result;
        public readonly Owner owner;
        public readonly Date date;

        public class Owner
        {
            public int ID { get; }
            public string Author { get; }
            public string Organization { get; }

            public Owner(int id, string author, string organization)
            {
                this.ID = id;
                this.Author = author;
                this.Organization = organization;
            }
        }
        public class Date
        {
            public DateTime Time { get; }

            public Date()
            {
                Time = DateTime.Now;
            }
        }

        public Set(int[] labaSet, int id = 999, string author = "dianazmitrevich", string organisation = "bgtu")
        {
            set = labaSet;
            this.date = new Date();
            this.owner = new Owner(id, author, organisation);
        }

        public Set(IEnumerable<int> result)
        {
            this.result = result;
        }

        // перегрузки операторов
        // > - проверка на принадлежность
        public static bool operator >(Set labaSet1, int num)
        {
            return labaSet1.set.Contains(num);
        }
        public static bool operator <(Set labaSet1, int num)
        {
            return labaSet1.set.Contains(num);
        }

        // * - пересечение множеств
        public static Set operator *(Set labaSet1, Set labaSet2)
        {
            var result = labaSet1.set.Intersect(labaSet2.set);
            return new Set(result);
        }

        // < - проверка на подмножество
        public static bool operator <(Set labaSet1, Set labaSet2)
        {
            var number = 0;
            for (int i = 0; i < labaSet1.set.Length; i++)
            {
                for (int j = 0; j < labaSet1.set.Length; j++)
                {
                    if (labaSet1.set[i] == labaSet2.set[j])
                    {
                        number++;
                    }
                }
            }
            if (number > 0)
                return true;
            else return false;
        }
        public static bool operator >(Set labaSet1, Set labaSet2)
        {
            var number = 0;
            for (int i = 0; i < labaSet1.set.Length; i++)
            {
                for (int j = 0; j < labaSet1.set.Length; j++)
                {
                    if (labaSet1.set[i] == labaSet2.set[j])
                    {
                        number++;
                    }
                }
            }
            if (number > 0)
                return true;
            else return false;
        }
    }
}
