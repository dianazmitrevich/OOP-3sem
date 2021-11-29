using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types

{
    public sealed class Film : TelevisionProgram, showInfo
    {
        public string name = "";
        public double rating = 0;
        public int feesCost = 0;

        public Film()
        {
            this.Duration = 0;
            this.AgeRange = 0;
            this.name = "";
            this.rating = 0;
            this.feesCost = 0;
        }

        public Film(int duration, int ageRange, string name, double rating) : base(duration)
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
            this.name = name;
            this.rating = rating;
        }

        public void showDuration()
        {
            double _hours = Duration / 60;
            double hours = Math.Floor(_hours);
            double minutes = Duration - (60 * hours);

            Console.WriteLine("{0} film goes for {1} hours and {2} minutes", this.name, (int)hours, (int)minutes);
        }

        public void editAgeRange(int ageRange = 0)
        {
            if (ageRange > 0)
                this.AgeRange = ageRange;
            else Console.WriteLine("Age range can't be less than 0");
        }

        public override string ToString()
        {
            return $"{this.name} film goes for {this.Duration} minutes \nAge limit is {this.AgeRange} and above years \nHighest rating found in Google is {this.rating} / 10";
        }
    }
}
