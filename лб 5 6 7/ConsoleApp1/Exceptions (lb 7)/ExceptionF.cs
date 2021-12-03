using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Exceptions__lb_7_
{
    public class ExceptionF : ExceptionTP
    {
        public string placeOfError;

        public ExceptionF(string placeOfError, string message) : base(placeOfError, message)
        {
            this.placeOfError = placeOfError;
        }
    }
}
