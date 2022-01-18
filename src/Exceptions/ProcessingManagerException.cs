using System;

namespace Clustering.Exceptions
{
    public class ProcessingManagerException: Exception
    {
        public string Message { get; }
        public ProcessingManagerException(string msg)
        {
            Message = msg;
        }
    }
}