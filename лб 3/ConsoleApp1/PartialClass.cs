using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    partial class Phone
    {
        public override bool Equals(object obj)
        {
            Phone name = obj as Phone;
            if (
                name.surname == this.surname
            )
                return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return this.id;
        }
    }
}
