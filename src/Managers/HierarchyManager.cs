using Clustering.Charts;
using Clustering.Clusterizators;
using Clustering.Clusterizators.Hierarchy;
using Clustering.src.Charts;
using Clustering.src.Managers;

namespace Clustering.Managers
{
    public class HierarchyManager : ClusteringManager
    {
       
        protected override IClusterizer CreateClusterizer()
        {
            return new HierarchyClusterizer();
        }
        protected override IChart CreateChart()
        {
            return new TreeChart();

        }
    }
}