using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class TelevisionProgram
    {
        // Вариант 8

        // Телевизионная программа, Фильм, Новости, Худ. фильм,
        // Мультфильм, Реклама, Режиссер

        public int duration;
        public int ageRange;
        public Producer producer;

        public int Duration
        {
            get => duration;
            set
            {
                if (duration > 0)
                    this.Duration = duration;
                else throw new Exception("Duration can't be less than 0");
            }
        }

        public int AgeRange
        {
            get => ageRange;
            set
            {
                if (ageRange > 0)
                    this.AgeRange = ageRange;
                else throw new Exception("Age range can't be less than 0");
            }
        }
    }
    public class Film : TelevisionProgram, IProgram
    {
        public string name;
        public void showDuration()
        {
            double _hours = duration / 60;
            double hours = Math.Floor(_hours);
            double minutes = duration - (60 * hours);

            Console.WriteLine("{0} film goes for {0} hours and {2} minutes", name, (int)hours, (int)minutes);
        }
        public void editAgeRange(int ageRange = 0)
        {
            this.AgeRange = ageRange;
        }
    }
}