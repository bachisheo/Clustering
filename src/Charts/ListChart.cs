using System;
using System.Collections.Generic;
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
                    sw.Write(", " + obj.ObjData[i]);
                }
                sw.Write("}");
                
                


        }

        public void Draw(List<Cluster> clusters, StreamWriter sw)
        {
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
    }
}
