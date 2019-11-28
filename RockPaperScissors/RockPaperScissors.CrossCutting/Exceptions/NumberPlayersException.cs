using System;
using System.Runtime.Serialization;

namespace RockPaperScissors.CrossCutting.Exceptions
{
    public class NumberPlayersException : Exception
    {
        public NumberPlayersException()
        {
        }

        public NumberPlayersException(string message) : base(message)
        {
        }

        public NumberPlayersException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NumberPlayersException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}