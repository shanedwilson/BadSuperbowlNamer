using System;
using System.Collections.Generic;
using System.Text;

namespace BadSuperbowlNamer
{
    public class InvalidInputException : Exception
    {
        public InvalidInputException() : base("The input received was invalid.")
        { }
    }
}
