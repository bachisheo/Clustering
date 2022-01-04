using System;
using System.Collections.Generic;
using System.IO;
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
        public ClusteringResult LastResult { get; protected set; }
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
            LastResult = clusterizer.Clustering(CleanSet);
            LastResult.CleanSet = CleanSet;
            LastResult.Clusterizer = clusterizer;
            LastResult.ResultName = CleanSet.Name;
            return LastResult;
        }

        public void Draw(StreamWriter sw) => chart.Draw(LastResult, sw);
    }
}
