using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Exceptions
{
      public  class ValueExceedException : Exception
    {
        public ValueExceedException(string message) : base(message) { }
    }
}
