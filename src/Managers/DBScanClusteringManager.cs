using Clustering.Clusterizators;

namespace Clustering.Managers
{
    public class DBScanClusteringManager : AbstractClusteringManager
    {
        public DBScanClusteringManager()
        {
            CreateClusterizer();
        }
        protected override IClusterizer CreateClusterizer()
        {
            _clusterizer = new DBScanAdapter();
            return _clusterizer;
        }
    }
}