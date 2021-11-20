using System;
using System.Collections.Generic;
using Clustering.Objects;
using Clustering.Clusterizators;

namespace Clustering
{
    class ClusterManager
    {
        private List<CleanObject> objects;
        private List<Cluster> clusters;
        private IClusterizer clusterizer;
    }
}
