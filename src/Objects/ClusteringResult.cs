using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Clustering.Clusterizators;

namespace Clustering.Objects
{
    public class ClusteringResult
    {
        public virtual List<Cluster> Clusters { get; } = new List<Cluster>();
        public int ClusteringResultId { get; set; }
        public string ResultName { get; set; }
        [NotMapped] public IClusterizer Clusterizer { get; set; }
        public virtual CleanSet CleanSet { get; set; }
    }
}