using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clustering.Objects;
using Clustering.src.Charts;

namespace Clustering.Charts
{
    class Chart : IChart
    {
        

        public void Draw(CleanObject obj, StreamWriter sw)
        {
                sw.Write("{");
                if(obj.Data.Length > 0)
                    sw.Write(obj.Data[0]);
                for (int i = 1; i < obj.Data.Length; i++)
                {
                    sw.Write(", " + obj.Data[i]);
                }
                sw.Write("}");
            
        }

        public void Draw(List<Cluster> clusters, StreamWriter sw)
        {
            for (int i = 0; i < clusters.Count; i++)
            {
                sw.Write("Cluster #" + (i + 1) +": ");
                if (clusters[i].Objects.Count > 0)
                    Draw(clusters[i].Objects[0], sw);
                for (int j = 1; j < clusters[i].Objects.Count; j++)
                {
                    sw.Write(", ");
                    Draw(clusters[i].Objects[j], sw);
                }
                sw.WriteLine();
            }
        }
    }
}
