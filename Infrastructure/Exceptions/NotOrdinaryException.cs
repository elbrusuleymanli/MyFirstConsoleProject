using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Exceptions
{
    class NotOrdinaryException:Exception
    {
        public NotOrdinaryException (string message) : base(message) { }
    }
}
