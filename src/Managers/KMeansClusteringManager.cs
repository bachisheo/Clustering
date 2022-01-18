namespace Clustering.Clusterizators
{
    public class KMeansClusteringManager : AbstractClusteringManager
    {
        public KMeansClusteringManager(int clusterCount)
        {
            _clusterCount = clusterCount;
            CreateClusterizer();
        }
        private int _clusterCount;
        protected override IClusterizer CreateClusterizer()
        {
            _clusterizer = new KMeansAlglibAdapter(_clusterCount);
            ((KMeansAlglibAdapter)_clusterizer).ClusterCount = _clusterCount;
            return _clusterizer;
        }

        public void SetClusterCount(int k)
        {
            _clusterCount = k;
            ((KMeansAlglibAdapter)_clusterizer).ClusterCount = _clusterCount;
        }
    }
}