using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators.Hierarchy
{
    public class HierarchyClusterizer: IClusterizer
    {
        private string _name = "Hierarchy Clusterizer";

        string IClusterizer.Name
        {
            get => _name;
            set => _name = value;
        }

        public ClusteringResult Clustering(CleanSet set)
        {
            throw new System.NotImplementedException();
        }
    }
}