using System;
using System.Runtime.Serialization;

namespace Assignment_3_skeleton
{
    [Serializable]
    internal class IndexOutOfBoundsException : Exception
    {
        public IndexOutOfBoundsException()
        {
        }

        public IndexOutOfBoundsException(string message) : base(message)
        {
        }

        public IndexOutOfBoundsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected IndexOutOfBoundsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}