using System;
using System.Collections.Generic;
using System.Text;

namespace CarOwner
{
    public class NameException : Exception
    {
        public NameException()
        {
        }

        public NameException(string message) : base(message)
        {
        }

        public NameException(string message, Exception innerException) : base(message, innerException)
        {
        }
    }
}
