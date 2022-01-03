using System.Collections.Generic;

namespace Clustering.Objects
{
    public class RawObject
    {
        public int RawObjectId { get; set; }

        public RawObject()
        {
            Logger log = Logger.Instance;
            log.Log("Raw object was created");
        } 
        public RawObject(double [] data, RawSet set)
        {
            ObjData = data;
            RawSet = set;
            Logger log = Logger.Instance;
            log.Log("Raw object was created");
        }

        public double[] ObjData { get; set; }
        public virtual RawSet RawSet { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();
    }
}