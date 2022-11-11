using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    internal class OutsideOfRangeInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to use input outside of the range needed. This fired an error!";
        }
    }
}
