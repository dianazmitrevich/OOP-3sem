using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Printer
    {
        public void IAmPrinting(TelevisionProgram tvProgram)
        {
            Console.WriteLine(tvProgram.ToString());
        }
    }
}
