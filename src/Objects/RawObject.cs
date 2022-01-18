using System.Collections.Generic;

namespace Clustering.Objects
{
    public class RawObject
    {
        public int RawObjectId { get; set; }

        public RawObject()
        {
            var log = FileLogger.Instance;
            log.Log("Raw object was created");
        } 
        public RawObject(double [] data, RawSet set)
        {
            ObjData = data;
            RawSet = set;
            var log = FileLogger.Instance;
            log.Log("Raw object was created");
        }

        public double[] ObjData { get; set; }
        public virtual RawSet RawSet { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
    }
}