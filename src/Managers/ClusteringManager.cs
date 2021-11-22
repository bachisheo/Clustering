using System;
using System.Collections.Generic;
using Clustering.Objects;
using Clustering.Clusterizators;
using Clustering.src.Charts;

namespace Clustering
{
    abstract class ClusteringManager
    {
        public CleanSet CleanSet { get; set; }
        public IChart chart { get; protected set; }

        protected IClusterizer clusterizer;

        protected abstract IClusterizer CreateClusterizer();

        public string ClusterInfo => clusterizer.Name;

        protected ClusteringManager()
        {
            clusterizer = CreateClusterizer();
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
