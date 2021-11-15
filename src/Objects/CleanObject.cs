using System;
using System.Collections.Generic;

namespace Clustering.Objects
{
    public class CleanObject
    {
        private static int _counter = 0;
        public int Id {get; private set; }

        public CleanObject(double [] data)
        {
            Data = data ?? throw new ArgumentNullException(nameof(data));
            Id = _counter++;
        }

        public double [] Data { get; }
    }
}