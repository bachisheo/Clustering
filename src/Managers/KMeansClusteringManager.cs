using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Clusterizators;

namespace Clustering.src.Managers
{
    class KMeansClusteringManager: ClusteringManager
    {
        public override IClusterizer CreaClusterizer()
        {
            return new KMeansAlglibAdapter();
        }
    }
}
