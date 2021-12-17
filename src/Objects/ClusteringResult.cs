using System.Collections.Generic;
using Clustering.Clusterizators;

namespace Clustering.Objects
{
    public class ClusteringResult
    {
        public virtual List<Cluster> Clusters { get; } = new List<Cluster>();
        public int ClusteringResultId { get; set; }
        public string ResultName { get; set; }
        public IClusterizer Clusterizer { get; set; }
        public CleanSet CleanSet { get; set; }
    }
}