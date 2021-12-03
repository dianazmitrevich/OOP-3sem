using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Exceptions__lb_7_;
using ConsoleApp1.Interfaces;

namespace ConsoleApp1.Types
{
    public sealed class Ad : TelevisionProgram, IShowInfo, IProducer
    {
        public string category = "";
        public string producerName = "";

        public Ad()
        {
            this.Duration = 0;
            this.AgeRange = 0;
            this.category = "";
            this.producerName = "";
        }

        public Ad(int duration, int ageRange, string category) : base(duration)
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
            this.category = category;
            this.producerName = "No info on producer";
        }

        public void showDuration()
        {
            Console.WriteLine("This ad goes for {0} minutes", Duration);
        }

        public void editAgeRange(int ageRange = 0)
        {
            if (ageRange > 0)
                this.AgeRange = ageRange;
            else throw new ExceptionF("Film.cs", "Age range can't be less than 0");
        }

        public void setProducer(string producerName = "")
        {
            this.producerName = producerName;
        }

        public override string ToString()
        {
            return $"This ad goes for {this.Duration} minutes \nAge limit is {this.AgeRange} and above years \nAd category is {this.category}\nProducer - {this.producerName}";
        }
    }
}
