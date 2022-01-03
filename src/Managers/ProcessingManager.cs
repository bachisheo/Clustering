using System;
using Clustering.DataBase;
using Clustering.Normalizers;
using Clustering.Objects;

namespace Clustering.Managers
{
    public class ProcessingManager
    {
        private ClusteringManager _clusterizer;
        private INormalizer _normalizer;
        private IDBLoader _dbLoader;

        public ProcessingManager(ClusteringManager clusterizer, INormalizer normalizer, IDBLoader dbLoader)
        {
            _clusterizer = clusterizer;
            _normalizer = normalizer;
            _dbLoader = dbLoader;
        }
        public ClusteringResult Execute(String dataSetName)
        {
            var rawSet = _dbLoader.GetRawSetByName(dataSetName);
            _clusterizer.CleanSet = _normalizer.Normalize(rawSet);
            return _clusterizer.Clusterize();
        } 
        public ClusteringResult Execute(double[][] data)
        {
            var rawSet = ConvertData(data);
            _clusterizer.CleanSet = _normalizer.Normalize(rawSet);
            return _clusterizer.Clusterize();
        }

        public RawSet ConvertData(Double[][] data)
        {
            var set = new RawSet();
            foreach (var obj in data)
            {
                set.Add(new RawObject(obj, set));
            }

            return set;
        }
     
    }
}