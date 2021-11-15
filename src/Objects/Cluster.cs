using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;

namespace Clustering.Objects
{
    public class Cluster
    {
        private List<CleanObject> objects = new List<CleanObject>();

        public List<CleanObject> Objects => objects;

        public void Add(CleanObject obj)
        {
            objects.Add(obj);
        }
    }
}
