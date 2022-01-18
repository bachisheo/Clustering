using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering
{
    /// <summary>
    /// Класс, экземпляры которого хранят снимки определенного ClusterChart
    /// </summary>
    public class MementoKeeper : IObserver
    {
        private PlaneChart.ClusterChart _chart;
        public List<ClusterChartMemento> mems;

        public MementoKeeper(PlaneChart.ClusterChart chart)
        {
            _chart = chart;
            mems = new List<ClusterChartMemento>();
        }

        public void Update(ClusteringResult result)
        {
            mems.Add(_chart.CreateMemento());
        }
    }
}