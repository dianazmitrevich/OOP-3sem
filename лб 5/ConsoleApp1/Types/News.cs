using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Types
{
    public partial class News : TelevisionProgram, showInfo
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
    }
}
