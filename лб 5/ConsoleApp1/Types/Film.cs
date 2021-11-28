using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public abstract class Film : TelevisionProgram, showInfo
    {
        public string name;

        public string Name
        {
            get => this.Name;
            set
            {
                this.Name = name;
            }
        }

        public Film(int duration, int ageRange, string name) : base(duration, ageRange, name) { }

        public void showDuration()
        {
            double _hours = duration / 60;
            double hours = Math.Floor(_hours);
            double minutes = duration - (60 * hours);

            Console.WriteLine("{0} film goes for {1} hours and {2} minutes", name, (int)hours, (int)minutes);
        }
        public void editAgeRange(int ageRange = 0)
        {
            if (ageRange > 0)
                this.AgeRange = ageRange;
            else throw new Exception("Age range can't be less than 0");
        }

        public virtual string classNameString()
        {
            return "Film";
        }
    }
}
