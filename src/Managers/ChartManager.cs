using System.Drawing;
using Clustering.Charts;
using Clustering.Objects;
using Clustering.PlaneChart;

namespace Clustering.Managers
{
    public class ChartManager : IObserver
    {
        private IChartImplementation _chart;

        public void Update(EventType eventType, ClusteringResult result)
        {

            CreateChart(result);
        }
        public void Draw(Graphics gr)
        {
            _chart.Draw(gr);
        }

        public ChartManager(IChartImplementation impl)
        {
            _chart = impl;
        }
        public void CreateChart(ClusteringResult result)
        {
            _chart.Reset();
            _chart.SetName(result.ResultName);

            Figure.FigureType[] figures = new[] { Figure.FigureType.circle, Figure.FigureType.rectangle };
            Color[] colors = new[] { Color.BlueViolet, Color.Blue, Color.BlueViolet };
            for (int i = 0; i < result.Clusters.Count; i++)
            {
                _chart.SetPointType(colors[i % colors.Length], figures[i % figures.Length], 20);
                foreach (var obj in result.Clusters[i].CleanObjects)
                {
                    _chart.SetPoint((float)obj.ObjData[0], (float)obj.ObjData[1]);
                }
            }
        }

      
    }
}
