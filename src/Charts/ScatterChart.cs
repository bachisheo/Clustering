using System;
using Clustering.Objects;
using Clustering.src.Charts;
using OxyPlot;
using OxyPlot.Series;

namespace Clustering.Charts
{
    public class ScatterChart 
    {
        private PlotModel model;
        public ScatterChart()
        {
            model = new PlotModel();
            model.Background = OxyColor.FromRgb(255, 255, 255);
        }
        public void Add(CleanObject obj)
        {

        }

        public void Add(ClusteringResult res)
        {
            var r = new Random(314);
            for (int i = 0; i < res.Clusters.Count; i++)
            {
                var a = new ScatterSeries
                { MarkerType = MarkerType.Circle, MarkerFill = OxyColor.FromRgb((byte)r.Next(0, 255), (byte)r.Next(0, 255), (byte)r.Next(0, 255)) };
                for (int j = 0; j < res.Clusters[i].CleanObjects.Count; j++)
                {
                    a.Points.Add(new ScatterPoint(res.Clusters[i].CleanObjects[j].ObjData[0], res.Clusters[i].CleanObjects[j].ObjData[1], 10, 1, 1));
                }
                model.Series.Add(a);
            }
        }
    }
}