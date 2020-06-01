using System;

namespace MyMoviesMVC.Common.Exceptions
{
    public class FlowException : Exception
    {
        public FlowException()
        {

        }

        public FlowException(string message) : base(message)
        {

        }
    }
}
