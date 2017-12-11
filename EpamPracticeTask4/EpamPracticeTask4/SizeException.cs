using System;
using System.Runtime.Serialization;

namespace EpamPracticeTask4
{
    /// <summary>
    /// Exception for illegall matrix size
    /// </summary>
    [Serializable]
    internal class SizeException : Exception
    {
        public SizeException()
        {
        }

        public SizeException(string message) : base(message)
        {
        }

        public SizeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected SizeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}