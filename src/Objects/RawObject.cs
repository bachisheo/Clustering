using System.Collections.Generic;

namespace Clustering.Objects
{
    public class RawObject
    {
        public int RawObjectId { get; set; }
        public DataSource DataSource { get; set; }

        public double[] ObjData { get; set; }
        public List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
    }
}