using System.Collections.Generic;
using Castle.DynamicProxy.Contributors;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    public interface IClusterizer
    {
        public static string Name { get; protected set; }
        public ClusteringResult Clustering(CleanSet dataSet);

        public string ToString()
        {
            return Name;
        }
    }
}