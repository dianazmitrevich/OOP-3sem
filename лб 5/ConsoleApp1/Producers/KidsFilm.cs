using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Producers
{
    class KidsFilm : Producer
    {
        public KidsFilm(string filmGenre = "", bool isFilmInCharts = true) : base(filmGenre, isFilmInCharts) { }

        public override void filmIsNotInCharts()
        {
            this.isFilmInCharts = false;
        }
    }
}
