using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class TelevisionProgram
    {
        // Вариант 8

        // Телевизионная программа, Фильм, Новости, Худ. фильм,
        // Мультфильм, Реклама, Режиссер

        private int duration;
        private int ageRange;

        public int Duration
        {
            get => duration;
            set
            {
                if (value >= 0)
                    duration = value;
                else Console.WriteLine("Duration can't be less than 0");
            }
        }

        public int AgeRange
        {
            get => ageRange;
            set
            {
                if (value >= 0)
                    ageRange = value;
                else Console.WriteLine("Age range can't be less than 0");
            }
        }

        public TelevisionProgram(int duration = 0, int ageRange = 0)
        {
            this.Duration = duration;
            this.AgeRange = ageRange;
        }

        public virtual string getString()
        {
            return "Virtual method for TelevisionProgram class";
        }

        public override int GetHashCode()
        {
            double hashCode = this.duration * this.ageRange / 24;
            return ((int)Math.Floor(hashCode));
        }

        public override bool Equals(object obj)
        {
            TelevisionProgram objectName = obj as TelevisionProgram;
            if (this.duration == objectName.duration)
                return true;
            else return false;
        }

        public override string ToString()
        {
            return $"Duration = {this.duration},\n Age range = {this.ageRange}";
        }
    }
}