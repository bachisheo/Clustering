using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Clusterizators;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    class KMeansAlglibAdapter : IClusterizer
    {
       public ClusteringResult Clustering(CleanSet set)
       {
           var objects = set.CleanObjects;
            double[,] data = new double[objects.Count, 2];
            for (int i = 0; i < objects.Count; i++)
            {
                data[i, 0] = objects[i].ObjData[0];
                data[i, 1] = objects[i].ObjData[1];
            }

            KMeansAlglib clusterizer = new KMeansAlglib();
            var report = clusterizer.clusterizerrunkmeans(data);
            var res = new ClusteringResult();
            var clusters = new List<Cluster>(report.k);
            
            for (int i = 0; i < clusters.Capacity; i++)
            {
                var c = new Cluster();
                c.Result = res;
                res.Clusters.Add(c);
            }
            for (int i = 0; i < report.cidx.Length; i++)
            {
                clusters[report.cidx[i]].Add(objects[i]);
            }
            return res;
        }
    }
}
