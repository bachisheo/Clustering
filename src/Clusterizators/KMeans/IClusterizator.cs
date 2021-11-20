using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    public interface IClusterizator
    {
        public List<Cluster> Clustering(List<CleanObject> objects);
    }
}