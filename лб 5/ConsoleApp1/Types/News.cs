using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class News : TelevisionProgram, showInfo
    {
        public News(int duration, int ageRange, string name) : base(duration, ageRange, name) { }

        public void showDuration()
        {
            Console.WriteLine("Episode goes for {0} minutes", duration);
        }
        public void editAgeRange(int ageRange = 0)
        {
            Console.WriteLine("This episode has no age limit!");
        }

        public virtual string classNameString()
        {
            return "News";
        }
    }
}
