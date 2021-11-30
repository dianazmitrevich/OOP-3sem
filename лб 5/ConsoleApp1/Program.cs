using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;
using ConsoleApp1.Container__lb_6_;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Film Scarface = new Film(170, 8, "Scarface", 8.7);
            Film IceAge = new Film(140, 8, "IceAge", 5.2);
            Film Twilight = new Film(150, 8, "Twilight", 4);

            var a = Scarface;
            News WorkPlace = new News(5, 8, "Employment");
            Ad IPhone13Promotion = new Ad(3, 8, "Mobile phones");
            Ad IPhone12Promotion = new Ad(5, 8, "Mobile phones");

            Printer printer = new Printer();
            printer.IAmPrinting(a);
            Console.WriteLine("\n");

            ProgramGuide programGuide = new ProgramGuide(Scarface, IceAge, Twilight, IPhone12Promotion, IPhone13Promotion);
            ProgramGuideController programGuideController = new ProgramGuideController();
            programGuideController.ratingAbove(programGuide);
            programGuideController.programGuideDuration(programGuide);
            programGuideController.adNumber(programGuide);

            Console.ReadKey();
        }
    }
}
