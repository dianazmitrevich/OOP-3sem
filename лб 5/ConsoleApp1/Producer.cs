using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Producer
    {
        public string filmGenre = "";
        protected bool isFilmInCharts = true;

        public bool IsFilmInCharts
        {
            get => this.isFilmInCharts;
        }

        public Producer(string filmGenre = "", bool isFilmInCharts = true)
        {
            this.filmGenre = filmGenre;
            this.isFilmInCharts = isFilmInCharts;
        }

        public abstract void filmIsNotInCharts();
    }
}
