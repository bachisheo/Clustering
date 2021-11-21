using System.Collections.Generic;

namespace Clustering.Objects
{
    public class RawSet
    {
        public int RawSetId { get; set; }
        public string SourceName { get; set; }
        public virtual List<RawObject> RawObjects { get; } = new List<RawObject>();
    }
}