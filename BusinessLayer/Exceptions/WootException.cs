using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Exceptions
{
    public class WootException : Exception
    {
        public WootException() : base()
        {
        }
        public WootException(string message) : base(message)
        {
        }
    }
}
