using Clustering.Clusterizators;
using Clustering.Clusterizators.Hierarchy;

namespace Clustering.Factory
{
    public class HierarchyClusterizerFactory : IClusterizerFactory
    {
        public IClusterizer CreateClusterizer()
        {
            return new HierarchyClusterizer();
        }
    }
}