using System;
using System.Collections.Generic;
using Clustering.Objects;
using Clustering.src.Charts;
using OxyPlot;
using OxyPlot.Series;

namespace Clustering.Charts
{
    public class BarChart
    {
        private PlotModel _model;
        private BarSeries _series;
        public void Add(CleanObject obj)
        {
        }

        public PlotModel GetResult()
        {
            _model = new PlotModel();
            _model.Background = OxyColor.FromRgb(255, 255, 255);
            _model.Series.Add(_series);
            return _model;
        }
        public void Add(ClusteringResult res)
        {
            var r = new Random(314);
            List<BarItem> items = new List<BarItem>(res.Clusters.Count);
            for (int i = 0; i < res.Clusters.Count; i++)
            {
                items[i] = new BarItem(res.Clusters[i].CleanObjects.Count);
            }

            _series = new BarSeries
            {
                ItemsSource = items,
                LabelPlacement = LabelPlacement.Inside,
                LabelFormatString = "{0:.00}%"
            };

        }
    }
}