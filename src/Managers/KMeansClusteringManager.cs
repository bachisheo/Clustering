using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Charts;
using Clustering.Clusterizators;
using Clustering.src.Charts;

namespace Clustering.src.Managers
{
    class KMeansClusteringManager: ClusteringManager
    {
        protected override IClusterizer CreateClusterizer()
        {
            return new KMeansAlglibAdapter();
        }

        protected override IChart CreateChart()
        {
            return new ListChart();
        }
    }
}
