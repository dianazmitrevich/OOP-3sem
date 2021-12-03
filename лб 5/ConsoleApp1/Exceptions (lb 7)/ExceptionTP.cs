using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions__lb_7_
{
    public class ExceptionTP : Exception
    {
        public string placeOfError;

        public ExceptionTP(string placeOfError, string message) : base(message)
        {
            this.placeOfError = placeOfError;
        }
    }
}
