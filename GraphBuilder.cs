using System;
using System.Drawing;
using Clustering.Builders;
using Clustering.Objects;
using OxyPlot;
using OxyPlot.Series;
using OxyPlot.WindowsForms;

namespace Clustering
{
    public class GraphBuilder: IViewBuilder
    {
        private PlotModel model = new PlotModel();
        public GraphBuilder()
        {
            Reset();
        }
        public void Reset()
        {
            model = new PlotModel();
            model.Background = OxyColor.FromRgb(255, 255, 255);

        }

        public void SetName(String name)
        {
            model.Title = name;
        }

        public void BuildDataView(ClusteringResult res)
        {
            var r = new Random(314);
           for (int i = 0; i < res.Clusters.Count; i++)
            {
                var a = new ScatterSeries
                    { MarkerType = MarkerType.Circle, MarkerFill = OxyColor.FromRgb((byte)r.Next(0, 255), (byte)r.Next(0, 255), (byte)r.Next(0, 255))};
                for (int j = 0; j < res.Clusters[i].CleanObjects.Count; j++)
                {
                    a.Points.Add(new ScatterPoint(res.Clusters[i].CleanObjects[j].ObjData[0], res.Clusters[i].CleanObjects[j].ObjData[1], 10, 1, 1));
                }
                model.Series.Add(a);
            }
        }

        public PlotModel GetResult()
        {
            return model;
        }
    }
}
