using System;
using Clustering.Objects;

namespace Clustering
{
    public enum EventType
    {
        clustering,
        updateData,
        updateClusterizer
    };
    public interface IObserver
    {
        public void Update(EventType eventType, ClusteringResult result);
    }
}