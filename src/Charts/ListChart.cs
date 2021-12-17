using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using Clustering.Objects;
using Clustering.src.Charts;
using OxyPlot;

namespace Clustering.Charts
{
    class ListChart : IChart
    {
        

        public void Draw(CleanObject obj, StreamWriter sw)
        {
                sw.Write("{");
                if(obj.ObjData.Length > 0)
                    sw.Write(obj.ObjData[0]);
                for (int i = 1; i < obj.ObjData.Length; i++)
                {
                    sw.Write(", " + obj.ObjData[i].ToString(CultureInfo.InvariantCulture));
                }
                sw.Write("}");
        }

        public void Draw(ClusteringResult result, StreamWriter sw)
        {
            sw.WriteLine("Dataset: " + result.CleanSet.Name);
            sw.WriteLine("Clusterizer: " + result.Clusterizer.Name);
            var clusters = result.Clusters;
            for (int i = 0; i < clusters.Count; i++)
            {
                sw.Write("Cluster #" + (i + 1) +": ");
                if (clusters[i].CleanObjects.Count > 0)
                    Draw(clusters[i].CleanObjects[0], sw);
                for (int j = 1; j < clusters[i].CleanObjects.Count; j++)
                {
                    sw.Write(", ");
                    Draw(clusters[i].CleanObjects[j], sw);
                }
                sw.WriteLine();
            }
        }

        public void Draw(CleanSet set, StreamWriter sw)
        {
            sw.Write("Set:" + set.Name + " ");

            if (set.CleanObjects.Count > 0)
                Draw(set.CleanObjects[0], sw);
            for (int j = 1; j < set.CleanObjects.Count; j++)
            {
                sw.Write(", ");
                Draw(set.CleanObjects[j], sw);
            }
            sw.WriteLine();
        }

    }
}
