using System;
using System.Collections.Generic;
using System.Text;

namespace Clustering
{
    interface IClusterIterator <T>
    {
        public bool HasNext();
        public T GetNext();
    }
}
