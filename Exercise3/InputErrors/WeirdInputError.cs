using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    internal class WeirdInputError : UserError
    {
        public override string UEMessage()
        {
            return "You entered some nonsense. This fired an error!";
        }
    }
}
