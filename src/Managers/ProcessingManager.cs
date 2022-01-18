using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using Clustering.DataBase;
using Clustering.Exceptions;
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
        public IReader Reader { get; set; }
        public RawSet DataRawSet { get; set; }
        public ProcessingManager()
        {
            Events = new List<EventManager>();
        }

        public bool CheckParams()
        {
            if (Clusterizer == null)
                throw new ProcessingManagerException("Кластеризатор не задан!");
            if(Normalizer == null)
                throw new ProcessingManagerException("Нормализатор не задан!");
            if (DataRawSet == null)
                throw new ProcessingManagerException("Набор данных не задан!");
            if (Reader == null)
                throw new ProcessingManagerException("База данных не доступна!");
            return true;
        }
        public ProcessingManager(ClusteringManager clusterizer, INormalizer normalizer, IReader reader)
        {
            Clusterizer = clusterizer;
            Normalizer = normalizer;
            Reader = reader;
        }
        public ClusteringResult Execute()
        {
            CheckParams();
            Clusterizer.CleanSet = Normalizer.Normalize(DataRawSet);
            var result = Clusterizer.Clusterize();
            foreach (var _event in Events)
            {
                _event.NotifyAll(EventType.clustering, result);
            }
            return result;
        } 
        public ClusteringResult Execute(String rawSetName)
        {
                CheckParams();
                var rawSet = Reader.GetRawSetByName(rawSetName);
                Clusterizer.CleanSet = Normalizer.Normalize(rawSet);
                return Clusterizer.Clusterize();
        } 
    }
}