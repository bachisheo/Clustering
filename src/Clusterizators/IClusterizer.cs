using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    public interface IClusterizer
    {
        public ClusteringResult Clustering(CleanSet set);
    }
}