using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Clustering.DataBase;
using Clustering.Normalizers;
using Clustering.Objects;
using Clustering.src.Observer;

namespace Clustering.Managers
{
    public class ProcessingManager
    {
        public List<EventManager> Events { set; get; }
        public ClusteringManager Clusterizer { get; set; }
        public INormalizer Normalizer { get; set; }
        public IDBLoader DbLoader { get; set; }
        public RawSet DataRawSet { get; set; }
        public ProcessingManager()
        {
            Events = new List<EventManager>();
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
           
            Clusterizer.CleanSet = Normalizer.Normalize(DataRawSet);
 
            var result = Clusterizer.Clusterize();
            foreach (var _event in Events)
            {
                _event.NotifyAll(EventType.clustering, result);
            }

            return result;
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