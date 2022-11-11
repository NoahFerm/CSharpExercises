using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3.InputErrors
{
    internal class EmptyInputError : UserError
    {
        public override string UEMessage()
        {
            return "You tried to leave the input empty. This fired an error!";
        }
    }
}
