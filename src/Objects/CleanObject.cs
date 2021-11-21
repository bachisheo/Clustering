using System;
using System.Collections.Generic;

namespace Clustering.Objects
{
    public class CleanObject
    {
        public int CleanObjectId {get; set; }
        
        public double [] ObjData { get; set; }
        public RawObject RawObject { get; set; }
        public List<Cluster> Clusters { get; } = new List<Cluster>();

    }
}