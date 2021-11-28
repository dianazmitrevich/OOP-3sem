using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public sealed class Ad : TelevisionProgram, showInfo
    {
        public Ad(int duration, int ageRange, string name) : base(duration, ageRange, name) { }

        public void showDuration()
        {
            Console.WriteLine("Ad goes for {0} minutes", duration);
        }
        public void editAgeRange(int ageRange = 0)
        {
            Console.WriteLine("This ad has no age limit!");
        }
    }
}
