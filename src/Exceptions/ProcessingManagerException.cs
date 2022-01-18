using System;

namespace Clustering.Exceptions
{
    public class ProcessingManagerException: Exception
    {
        public override string Message { get; }
        public ProcessingManagerException(string msg)
        {
            Message = msg;
        }
    }
}