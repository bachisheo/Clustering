using System;
using Clustering.Normalizers;
using Clustering.Objects;

namespace Clustering.Managers
{
    public class ProcessingManager
    {
        private ClusteringManager _clusterizer;
        private INormalizer _normalizer;

        public ProcessingManager(ClusteringManager clusterizer, INormalizer normalizer)
        {
            _clusterizer = clusterizer;
            _normalizer = normalizer;
        }

        private RawSet ConvertData(Double[][] data)
        {
            var set = new RawSet();
            foreach (var obj in data)
            {
                set.Add(new RawObject(obj, set));
            }

            return set;
        }
        public ClusteringResult Execute(double[][] data)
        {
            var rawSet = ConvertData(data);
            _clusterizer.CleanSet = _normalizer.Normalize(rawSet);
            return _clusterizer.Clusterize();
        }
    }
}