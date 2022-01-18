using System.Collections.Generic;
using System.Security;
using Clustering.Objects;


namespace Clustering.Clusterizators
{
    public class DBScanAdapter : IClusterizer
    {
        private List<DBScan.Point> ConvertDataSetToList(CleanSet dataSet)
        {
            var data = new List<DBScan.Point>(dataSet.CleanObjects.Count);
            foreach (var obj in dataSet.CleanObjects)
            {
                data.Add(new DBScan.Point((int)obj.ObjData[0], (int)obj.ObjData[1]));
            }

            return data;
        }

        private void ConvertListToResult(List<List<DBScan.Point>> dbsRes, ClusteringResult res)
        {
            //res.Clusters = new List<Cluster>(dbsRes.Count);
            foreach (var cluster in dbsRes)
            {
                var resCluster = new Cluster();
                foreach (var obj in cluster)
                {
                    //todo rawobject in cleanobject safe
                    resCluster.CleanObjects.Add(new CleanObject{CleanSet = res.CleanSet, ObjData = new double[]{ obj.X, obj.Y }});
                }
                res.Clusters.Add(resCluster);
            }
        }

        public ClusteringResult Clustering(CleanSet dataSet)
        {
            var result = new ClusteringResult();
            result.CleanSet = dataSet;
            var dbsSet = ConvertDataSetToList(dataSet);
            var dbsRes = DBScan.GetClusters(dbsSet, 0.5, 1);
            ConvertListToResult(dbsRes, result);
            var noiseCluster = new Cluster { Name = "Noise" };
            //добавить выбросы в отдельный кластер
            foreach (var ptr in dbsSet)
            {
                if(ptr.ClusterId == DBScan.Point.NOISE)
                    noiseCluster.Add(new CleanObject { CleanSet = dataSet, ObjData = new double[] { ptr.X, ptr.Y } });
            }
            if(noiseCluster.CleanObjects.Count > 0)
                result.Clusters.Add(noiseCluster);
            return result;
        }

        public override string ToString()
        {
            return "DBScan from GitHub";
        }
    }
}