using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Exceptions
{
    class QuantityExceededException:Exception
    {
        public QuantityExceededException(string message) : base(message) { }
    }
}
