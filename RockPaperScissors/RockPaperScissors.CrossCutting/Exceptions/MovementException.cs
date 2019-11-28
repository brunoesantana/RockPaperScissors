using System;
using System.Runtime.Serialization;

namespace RockPaperScissors.CrossCutting.Exceptions
{
    public class MovementException : Exception
    {
        public MovementException()
        {
        }

        public MovementException(string message) : base(message)
        {
        }

        public MovementException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected MovementException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}