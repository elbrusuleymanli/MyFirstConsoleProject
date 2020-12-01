using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Exceptions
{
    public class outRangeException:Exception
    {
        public outRangeException (string message) : base(message) { }
    }
}
