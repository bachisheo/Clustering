using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    public interface IClusterizer
    {
        public string Name { get; protected set; }
        public ClusteringResult Clustering(CleanSet set);
    }
}