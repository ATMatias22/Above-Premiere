using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Above_Premiere.Controller
{
    public class IncorrectCredentialsException : SystemException
    {

        public IncorrectCredentialsException(String message) : base(message)
        {

        }

    }
}
