using System.Collections.Generic;

namespace Clustering.Objects
{
    public class CleanSet
    {
        public int CleanSetId { get; set; }
        public string Name { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();

    }
}