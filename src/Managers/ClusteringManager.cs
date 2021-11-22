using System;
using System.Collections.Generic;
using Clustering.Charts;
using Clustering.Objects;
using Clustering.Clusterizators;
using Clustering.src.Charts;

namespace Clustering
{
    public abstract class ClusteringManager
    {
        public CleanSet CleanSet { get; set; }
        public IChart chart { get; protected set; }

        protected IClusterizer clusterizer;

        protected abstract IClusterizer CreateClusterizer();
        protected abstract IChart CreateChart();

        public string ClusterInfo => clusterizer.Name;

        protected ClusteringManager()
        {
            clusterizer = CreateClusterizer();
            chart = CreateChart();
        }
        public ClusteringResult Clusterize()
        {
            if (CleanSet == null)
            {
                Logger.Instance.Log("Empty Dataset!");
            }
            return clusterizer.Clustering(CleanSet);
        }
      
    }
}
