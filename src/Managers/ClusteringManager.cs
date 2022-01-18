using Clustering.Objects;
using Clustering.Clusterizators;

namespace Clustering
{
    public class ClusteringManager
    {
        public CleanSet CleanSet { get; set; }
        public ClusteringResult LastResult { get; protected set; }
        protected IClusterizer _clusterizer;

        public override string ToString()
        {
            if (_clusterizer == null)
                return "null";
            return _clusterizer.Name ;
        }

        public ClusteringManager(IClusterizer clusterizer)
        {
            _clusterizer = clusterizer;
        }
        public ClusteringResult Clusterize()
        {
            if (CleanSet == null)
            {
                Logger.Instance.Log("Empty Dataset!");
            }
            LastResult = _clusterizer.Clustering(CleanSet);
            LastResult.CleanSet = CleanSet;
            LastResult.Clusterizer = _clusterizer;
            LastResult.ResultName = CleanSet.Name;
            return LastResult;
        }
    }
}
