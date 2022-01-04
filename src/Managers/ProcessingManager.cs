using System;
using Clustering.DataBase;
using Clustering.Normalizers;
using Clustering.Objects;

namespace Clustering.Managers
{
    public class ProcessingManager
    {
        public ClusteringManager Clusterizer { get; set; }
        public INormalizer Normalizer { get; set; }
        public IDBLoader DbLoader { get; set; }

        public ProcessingManager()
        {
        }

        public bool IsAllParamsInitialized()
        {
            return Clusterizer != null && !(Clusterizer is { CleanSet: null });
        }
        public ProcessingManager(ClusteringManager clusterizer, INormalizer normalizer, IDBLoader dbLoader)
        {
            Clusterizer = clusterizer;
            Normalizer = normalizer;
            DbLoader = dbLoader;
        }
        public ClusteringResult Execute()
        {
            return Clusterizer.Clusterize();
        } 
        public ClusteringResult Execute(String dataSetName)
        {
            var rawSet = DbLoader.GetRawSetByName(dataSetName);
            Clusterizer.CleanSet = Normalizer.Normalize(rawSet);
            return Clusterizer.Clusterize();
        } 
        public ClusteringResult Execute(double[][] data)
        {
            var rawSet = ConvertData(data);
            Clusterizer.CleanSet = Normalizer.Normalize(rawSet);
            return Clusterizer.Clusterize();
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