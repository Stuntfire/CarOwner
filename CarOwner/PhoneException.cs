using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    public class PhoneException : Exception
    {
        public PhoneException()
        {
        }

        public PhoneException(string message) : base(message)
        {
        }

        public PhoneException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
