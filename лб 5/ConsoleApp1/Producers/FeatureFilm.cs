using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Producers
{
    class FeatureFilm : Producer
    {
        public FeatureFilm(string filmGenre = "", bool isFilmInCharts = true) : base(filmGenre, isFilmInCharts) { }

        public override void filmIsNotInCharts()
        {
            this.isFilmInCharts = false;
        }
    }
}
