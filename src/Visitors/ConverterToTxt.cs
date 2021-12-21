using System;
using System.IO;
using System.Text;
using Clustering.Objects;

namespace Clustering.Visitors
{
    public class ConverterToTxt : IVisitor
    {
        private StringBuilder sb;

        public String Convert(ClusteringResult result)
        {
            sb = new StringBuilder();
            Visit(result);
            return sb.ToString();
        }
        public String Convert(CleanSet cleanSet)
        {
            sb = new StringBuilder();
            Visit(cleanSet);
            return sb.ToString();
        }
        public void Visit(ClusteringResult result)
        {
            sb.Append("Результат кластеризации: " + result.ResultName);
            for (int i = 0; i < result.Clusters.Count; i++)
            {
                sb.Append("\nКластер #" + (i + 1) + ": ");
                Visit(result.Clusters[i]);
            }
        }

        public void Visit(Cluster cluster)
        {
            sb.Append(cluster.Name);
            sb.Append("{");
            if (cluster.CleanObjects.Count > 0)
                sb.Append(cluster.CleanObjects[0]);
            for (int i = 0; i < cluster.CleanObjects.Count; i++)
            {
                sb.Append(", ");
                Visit(cluster.CleanObjects[i]);
            }
            sb.Append("}");
        }
        public void Visit(CleanSet cleanSet)
        {
            sb.Append(cleanSet.Name);
            sb.Append("{");
            if (cleanSet.CleanObjects.Count > 0)
                sb.Append(cleanSet.CleanObjects[0]);
            for (int i = 0; i < cleanSet.CleanObjects.Count; i++)
            {
                sb.Append(", ");
                Visit(cleanSet.CleanObjects[i]);
            }
            sb.Append("}");
        }
        public void Visit(CleanObject cleanObject)
        {
            sb.Append("[");
            if(cleanObject.ObjData.Length > 0)
                sb.Append(cleanObject.ObjData[0]);
            for (int i = 1; i < cleanObject.ObjData.Length; i++)
            {
                sb.Append("; ");
                sb.Append(cleanObject.ObjData[0]);
            }
            sb.Append("]");
        }
    }
}