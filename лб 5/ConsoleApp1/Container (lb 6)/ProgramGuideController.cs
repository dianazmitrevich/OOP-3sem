using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;

namespace ConsoleApp1.Container__lb_6_
{
    public class ProgramGuideController
    {
        // Создать Программу передач.
        // Найти все фильмы, снятые в определенный год (с рейтингом более 5), подсчитать
        // продолжительность программы по времени, число
        // рекламных роликов.

        public void ratingAbove(ProgramGuide programGuide)
        {
            Console.WriteLine("Found films with rating above 5.0:");

            for (int i = 0; i < programGuide.programArray.Length; i++)
            {
                if (programGuide.programArray[i] is Film)
                {
                    Film foundFilm = programGuide.programArray[i] as Film;

                    if (foundFilm.rating > 5)
                        Console.WriteLine(foundFilm.name);
                }
            }
        }

        public void programGuideDuration(ProgramGuide programGuide)
        {
            Console.WriteLine("Program guide duration is ");

            int duration = 0;
            for (int i = 0; i < programGuide.programArray.Length; i++)
            {
                if (programGuide.programArray[i] is TelevisionProgram)
                {
                    TelevisionProgram tvprogram = programGuide.programArray[i] as TelevisionProgram;
                    duration += tvprogram.Duration;
                }
            }
            Console.WriteLine("minutes!");
        }

        public void adNumber(ProgramGuide programGuide)
        {
            Console.WriteLine("Ad number is ");

            int number = 0;
            for (int i = 0; i < programGuide.programArray.Length; i++)
            {
                if (programGuide.programArray[i] is Ad)
                    number++;
            }
        }
    }
}
