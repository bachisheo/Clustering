using System.Collections.Generic;

namespace Clustering.Objects
{
    public class ClusteringResult
    {
        public List<Cluster> Clusters { get; } = new List<Cluster>();
        public int ClusteringResultId { get; set; }
        public string ResultName { get; set; }
    }
}