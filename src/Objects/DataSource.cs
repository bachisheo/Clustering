using System.Collections.Generic;

namespace Clustering.Objects
{
    public class DataSource
    {
        public int DataSourceId { get; set; }
        public string SourceName { get; set; }
        public List<RawObject> RawObjects { get; } = new List<RawObject>();
    }
}