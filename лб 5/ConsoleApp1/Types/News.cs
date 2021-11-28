using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public class News : TelevisionProgram, showInfo
    {
        public string category = "";

        public News()
        {
            this.Duration = 0;
            this.AgeRange = 0;
            this.category = "";
        }

        public News(int duration, int ageRange, string category) : base(duration)
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
            this.category = category;
        }

        public void showDuration()
        {
            Console.WriteLine("This news episode goes for {0} minutes", Duration);
        }

        public void editAgeRange(int ageRange = 0)
        {
            if (ageRange > 0)
                this.AgeRange = ageRange;
            else Console.WriteLine("Age range can't be less than 0");
        }
    }
}
