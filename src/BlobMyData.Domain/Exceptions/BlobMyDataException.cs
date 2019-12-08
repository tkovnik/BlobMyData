using System;
using System.Collections.Generic;
using System.Text;

namespace BlobMyData.Domain.Exceptions
{
    public class BlobMyDataException : Exception
    {
        public BlobMyDataException(string errorMessage)
            : this(errorMessage, null)
        {
        }

        public BlobMyDataException(string errorMessage, Exception innerException)
            : base(errorMessage, innerException)
        {
        }
    }
}
