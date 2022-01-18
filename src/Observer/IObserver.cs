using System;
using Clustering.Objects;

namespace Clustering
{
    public interface IObserver
    {
        public void Update(ClusteringResult result);
    }
}