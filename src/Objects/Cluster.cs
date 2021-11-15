using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;

namespace Clustering.Objects
{
    class Cluster
    {
        private List<CleanObject> objects;

        public List<CleanObject> Get => objects;

        public void Add(CleanObject obj)
        {
            objects.Add(obj);
        }
    }
}
