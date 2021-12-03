using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;

namespace ConsoleApp1.Film_categories
{
    public class FeatureFilm : Film
    {
        public string filmCategory = "Feature film";

        public FeatureFilm(int duration, int ageRange, string name, double rating) : base(duration, ageRange, name, rating)
        {
            this.producerName = "No info on producer";
        }

        public override string ToString()
        {
            return $"{this.filmCategory} {this.name} goes for {this.duration} minutes\nAge limit is {this.AgeRange} and above years \nHighest rating found in Google is {this.rating} / 10\nProducer - {this.producerName}";
        }
    }
}
