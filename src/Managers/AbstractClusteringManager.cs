using Clustering.Objects;
using Clustering.Clusterizators;

namespace Clustering
{
    public abstract class AbstractClusteringManager
    {
        public CleanSet CleanSet { get; set; }
        public ClusteringResult LastResult { get; protected set; }
        protected IClusterizer _clusterizer;

        public override string ToString()
        {
            if (_clusterizer == null)
                return "null";
            return _clusterizer.ToString();
        }

        protected abstract IClusterizer CreateClusterizer();
        public ClusteringResult Clusterize()
        {
            if (CleanSet == null)
            {
                FileLogger.Instance.Log("Empty Dataset!");
            }
            LastResult = _clusterizer.Clustering(CleanSet);
            LastResult.CleanSet = CleanSet;
            LastResult.Clusterizer = _clusterizer;
            LastResult.ResultName = CleanSet.Name;
            return LastResult;
        }
    }
}
