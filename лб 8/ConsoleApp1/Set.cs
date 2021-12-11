using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Set<T> : Interface<T> where T : class
    {
        public T[] set;
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

        public Set(T[] labaSet, int id = 999, string author = "dianazmitrevich", string organisation = "bgtu")
        {
            set = labaSet;
            this.date = new Date();
            this.owner = new Owner(id, author, organisation);
        }

        public Set(IEnumerable<int> result)
        {
            this.result = result;
        }

        // методы интерфейса
        public void Add(T element)
        {
            this.set = this.set.Append(element).ToArray();
        }

        public void Del(int i)
        {
            try
            {
                if (i < 0 || i >= this.set.Length)
                    throw new Exception("No such element exists to delete from array!");
                this.set = this.set.Where((e, j) => j != i).ToArray();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("Code is running...");
            }
        }

        public void Show()
        {
            foreach (T element in this.set)
                Console.Write($"{element} ");
        }
    }
}
