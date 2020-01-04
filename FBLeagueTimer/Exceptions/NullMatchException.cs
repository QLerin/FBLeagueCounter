using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace FBLeagueTimer.Exceptions
{
    public class NullMatchException : Exception
    {
        public NullMatchException()
        {
        }

        public NullMatchException(string message) : base(message)
        {
        }

        public NullMatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NullMatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
