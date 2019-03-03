using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Exceptions
{
    public class PendingBookingException : Exception
    {
        public PendingBookingException(string message) : base(message)
        {
        }
    }
}
