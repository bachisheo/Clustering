using System.Collections.Generic;

namespace Clustering.Objects
{
    public class RawObject
    {
        public int RawObjectId { get; set; }

        public double[] ObjData { get; set; }
        public virtual RawSet RawSet { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
    }
}