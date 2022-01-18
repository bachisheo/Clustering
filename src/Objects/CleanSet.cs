using System.Collections.Generic;

namespace Clustering.Objects
{
    public class CleanSet
    {
        private static int maxId;
        public int CleanSetId { get; set; }
        public string Name { get; set; }
        public virtual List<CleanObject> CleanObjects { get; } = new List<CleanObject>();

        public CleanSet Clone()
        {
            var clone = new CleanSet { CleanSetId = maxId++, Name = this.Name + "Copy" };
            foreach(var obj in CleanObjects)
            {
                var cloneObj = new CleanObject(obj, this);
                clone.CleanObjects.Add(cloneObj);
            }
            return clone;
        }

        public void Add(CleanObject obj)
        {
            CleanObjects.Add(obj);
        }
    }
}