using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Producer
    {
        public string name = "";
        public string workingHours = "";
        protected bool isWorkingYet = true;

        public bool IsWorkingYet
        {
            get => this.IsWorkingYet;
        }

        public abstract void retireTheProducer();
    }
}
