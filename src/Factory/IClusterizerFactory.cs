using Clustering.Clusterizators;
using Clustering.src.Charts;

namespace Clustering.Factory
{
    public interface IClusterizerFactory
    {
        public IClusterizer CreateClusterizer();
    }
}