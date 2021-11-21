using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;

namespace Clustering.Objects
{
    public class Cluster
    {
        public List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
        public int ClusterId { get; set; }
        public string Name { get; set; }
        public ClusteringResult Result { get; set; }

        public void Add(CleanObject obj)
        {
            CleanObjects.Add(obj);
        }
    }
}
