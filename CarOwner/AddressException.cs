using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    public class AddressException : Exception
    {
        public AddressException()
        {
        }

        public AddressException(string message) : base(message)
        {
        }

        public AddressException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
