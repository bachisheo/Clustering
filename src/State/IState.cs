using System;
using Clustering.Managers;
using Clustering.Objects;

namespace Clustering
{
    public interface IState
    {
        public void Clusterize();
        public void Clear();
        public void DrawResult();
        public void SetClusterizer(ClusteringManager manager);
        public void SetData(RawSet dataSet);
    }
}