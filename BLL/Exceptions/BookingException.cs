using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Exceptions
{
    public class BookingException : Exception
    {
        public BookingException(string message) : base(message)
        {
        }
    }
}
