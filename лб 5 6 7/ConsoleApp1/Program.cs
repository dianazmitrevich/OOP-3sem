using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1.Types;
using ConsoleApp1.Container__lb_6_;
using ConsoleApp1.Exceptions__lb_7_;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Film Scarface = new Film(170, 8, "Scarface", 8.7);
                Film IceAge = new Film(140, 8, "IceAge", 5.2);
                Film Twilight = new Film(150, 8, "Twilight", 4);
                News WorkPlace = new News(5, 8, "Employment");
                Ad IPhone13Promotion = new Ad(3, 8, "Mobile phones");
                Ad IPhone12Promotion = new Ad(5, 8, "Mobile phones");

                Film exceptionFilm = new Film(1, 9, "exceptionFilm", 4);

                // Film exceptionFilm_ = new Film(1, -9, "exceptionFilm_", 4); // ExceptionTP
                // exceptionFilm.editAgeRange(-20); // ExceptionF

                //var b = IceAge;
                Printer printer = new Printer();
                printer.IAmPrinting(IceAge);
                Console.WriteLine();

                ProgramGuide programGuide = new ProgramGuide(Scarface, IceAge, Twilight, IPhone12Promotion, IPhone13Promotion);
                ProgramGuideController programGuideController = new ProgramGuideController();
                programGuideController.ratingAbove(programGuide);
                programGuideController.programGuideDuration(programGuide);
                programGuideController.adNumber(programGuide);

                // int[] aa = null;
                // Debug.Assert(aa != null, "Values array cannot be null");
            }

            catch (ExceptionTP ex)
            {
                Console.WriteLine($"Exception found in {ex.placeOfError}! {ex.Message}");
            }

            finally
            {
                Console.WriteLine("\nCode is running...");
            }

            Console.ReadKey();
        }
    }
}
