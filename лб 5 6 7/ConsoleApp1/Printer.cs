using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;
using ConsoleApp1.Film_categories;

namespace ConsoleApp1
{
    public class Printer
    {
        public void IAmPrinting(TelevisionProgram tvProgram)
        {
            if(tvProgram is Film)
            {
                Film result = tvProgram as Film;
                Console.WriteLine(result.ToString());
            }

            else if (tvProgram is FeatureFilm)
            {
                FeatureFilm result = tvProgram as FeatureFilm;
                Console.WriteLine(result.ToString());
            }

            else if (tvProgram is KidsFilm)
            {
                KidsFilm result = tvProgram as KidsFilm;
                Console.WriteLine(result.ToString());
            }

            else if(tvProgram is News)
            {
                News result = tvProgram as News;
                Console.WriteLine(result.ToString());
            }

            else if (tvProgram is Ad)
            {
                Ad result = tvProgram as Ad;
                Console.WriteLine(result.ToString());
            }
        }
    }
}
