using System;
using System.Collections.Generic;

namespace Clustering.Objects
{
    public class CleanObject
    {
        public static int maxid;
        public int CleanObjectId {get; set; }
        
        public double [] ObjData { get; set; }
        public virtual RawObject RawObject { get; set; }
        public virtual CleanSet CleanSet { get; set; }
        public virtual List<Cluster> Clusters { get; } = new List<Cluster>();

        public CleanObject Clone()
        {
            return new CleanObject { CleanObjectId = maxid++, ObjData = this.ObjData, RawObject = this.RawObject};
        }

    }
}