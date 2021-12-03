using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Types
{
    public partial class News : TelevisionProgram, IShowInfo, IProducer
    {
        public string category = "";
        public string producerName = "";

        public News()
        {
            this.Duration = 0;
            this.AgeRange = 0;
            this.category = "";
            this.producerName = "";
        }

        public News(int duration, int ageRange, string category) : base(duration)
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
            this.category = category;
            this.producerName = "No info on producer";
        }
    }
}
