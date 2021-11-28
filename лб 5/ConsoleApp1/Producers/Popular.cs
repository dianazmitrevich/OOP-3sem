 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Producers
{
    class Popular : Producer
    {
        public Popular(string name = "", string workingHours = "") : base(name, workingHours) { }

        public override void retireTheProducer()
        {
            this.isWorkingYet = false;
        }
    }
}
