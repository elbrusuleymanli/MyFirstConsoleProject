using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Infrastructure.Exceptions
{
    class NotFoundExp:Exception
    {
        NotFoundExp(string message) : base(message) { }
}
}
