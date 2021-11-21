using System;
using System.Collections.Generic;
using Clustering.Objects;
using Clustering.Clusterizators;
using Clustering.src.Charts;

namespace Clustering
{
    abstract class ClusteringManager
    {
        private CleanSet cleanSet;
        private IChart chart;
        private IClusterizer clusterizer;
        public abstract IClusterizer CreaClusterizer();

        public ClusteringResult Clusterize()
        {
            return clusterizer.Clustering(cleanSet);
        }
    }
}
