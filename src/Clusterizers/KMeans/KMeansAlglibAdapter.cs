using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Clusterizators;
using Clustering.Objects;

namespace Clustering.Clusterizators
{
    class KMeansAlglibAdapter : IClusterizer
    {
        private string _name = "KMeans from the Alglib library";
        public int ClusterCount { get; set; }
        string IClusterizer.Name
        {
            get => _name;
            set => _name = value;
        }

        public KMeansAlglibAdapter(int K)
        {
            ClusterCount = K;
        }
        public ClusteringResult Clustering(CleanSet dataSet)
       {
           var objects = dataSet.CleanObjects;
            double[,] data = new double[objects.Count, 2];
            for (int i = 0; i < objects.Count; i++)
            {
                data[i, 0] = objects[i].ObjData[0];
                data[i, 1] = objects[i].ObjData[1];
            }

            KMeansAlglib clusterizer = new KMeansAlglib();
            var report = clusterizer.clusterizerrunkmeans(data, ClusterCount);
            var res = new ClusteringResult();
            for (int i = 0; i < report.k; i++)
            {
                var c = new Cluster();
                c.Result = res;
                res.Clusters.Add(c);
            }
            for (int i = 0; i < report.cidx.Length; i++)
            {
                res.Clusters[report.cidx[i]].Add(objects[i]);
            }
            return res;
        }
    }
}
