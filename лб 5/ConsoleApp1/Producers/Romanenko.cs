using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Romanenko : Producer
    {
        public Romanenko(string WorkingHours = "9 - 18")
        {
            this.name = "Romanenko";
            this.workingHours = WorkingHours;
        }

        public override void retireTheProducer()
        {
            this.isWorkingYet = false;
        }
    }
}
