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
        // < - проверка на подмножество, явный Date() - приведение
        // типа 

        // Методы расширения:
        // 1) Выделение первого числа, содержащегося в строке
        // 2) Удаление положительных элементов из множества

        public int[] set;
        public readonly Date date;
        public readonly Owner owner;

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
    }
}
