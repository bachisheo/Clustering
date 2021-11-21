using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    public interface IClusterizer
    {
        public List<Cluster> Clustering(List<CleanObject> objects);
    }
}