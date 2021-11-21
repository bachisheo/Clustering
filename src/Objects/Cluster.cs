using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;

namespace Clustering.Objects
{
    public class Cluster
    {
        public int ClusterId { get; set; }
        public string Name { get; set; }
        public virtual ClusteringResult Result { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
        public void Add(CleanObject obj)
        {
            CleanObjects.Add(obj);
        }
    }
}
