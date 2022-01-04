using System.Drawing;
using Clustering.Charts;
using Clustering.Objects;
using Clustering.PlaneChart;

namespace Clustering.Managers
{
    public class ChartManager : IObserver
    {
        public IChartImplementation Chart { get; }


        public void Update(EventType eventType, ClusteringResult result)
        {

            CreateChart(result);
        }
        public void Draw(Graphics gr)
        {
            Chart.Draw(gr);
            
        }

        public ChartManager(IChartImplementation impl)
        {
            Chart = impl;
        }
        public void CreateChart(ClusteringResult result)
        {
            Chart.Reset();
            Chart.SetName(result.ResultName);

            Figure.FigureType[] figures = new[] { Figure.FigureType.circle, Figure.FigureType.rectangle };
            Color[] colors = new[] { Color.BlueViolet, Color.Blue, Color.BlueViolet };
            for (int i = 0; i < result.Clusters.Count; i++)
            {
                Chart.SetPointType(colors[i % colors.Length], figures[i % figures.Length], 20);
                foreach (var obj in result.Clusters[i].CleanObjects)
                {
                    Chart.SetPoint((float)obj.ObjData[0], (float)obj.ObjData[1]);
                }
            }
        }

      
    }
}
