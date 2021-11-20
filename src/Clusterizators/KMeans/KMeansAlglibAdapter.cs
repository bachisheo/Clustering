using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Clusterizators;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    class KMeansAlglibAdapter : IClusterizator
    {
        public List<Cluster> Clustering(List<CleanObject> objects)
        {
            double[,] data = new double[objects.Count, 2];
            for (int i = 0; i < objects.Count; i++)
            {
                data[i, 0] = objects[i].Data[0];
                data[i, 1] = objects[i].Data[1];
            }

            KMeansAlglib clusterizer = new KMeansAlglib();
            var report = clusterizer.clusterizerrunkmeans(data);
            var clusters = new List<Cluster>(report.k);
            for (int i = 0; i < clusters.Capacity; i++)
            {
                clusters.Add(new Cluster());
            }
            for (int i = 0; i < report.cidx.Length; i++)
            {
                clusters[report.cidx[i]].Add(objects[i]);
            }
            return clusters;
        }
    }
}
