using System;
using Clustering.Objects;

namespace Clustering.Builders
{
    public interface IViewBuilder
    {
        public void Reset();
        public void SetName(String name);
        public void BuildDataView(ClusteringResult res);
     

    }
}