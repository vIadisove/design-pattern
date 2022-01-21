using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Mallart : Duck
    {
        public override string Display()
        {
            return "Display" + " " + this.GetType();
        }
    }
}
