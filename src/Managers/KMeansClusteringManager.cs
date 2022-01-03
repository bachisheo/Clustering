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
        public KMeansClusteringManager(int clusterCount)
        {
            _clusterCount = clusterCount;
            ((KMeansAlglibAdapter)clusterizer).ClusterCount = _clusterCount;
        }
        private int _clusterCount;
        protected override IClusterizer CreateClusterizer()
        {
            clusterizer = new KMeansAlglibAdapter();
            ((KMeansAlglibAdapter)clusterizer).ClusterCount = _clusterCount;
            return clusterizer;
        }

        protected override IChart CreateChart()
        {
            return new ListChart();
        }
    }
}
