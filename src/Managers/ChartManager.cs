using System.Drawing;
using Clustering.Charts;
using Clustering.Objects;
using Clustering.PlaneChart;

namespace Clustering.Managers
{
    public class ChartManager : IObserver
    {
        public IChartImplementation Impl { get; }


        public void Update(EventType eventType, ClusteringResult result)
        {
            CreateChart(result);
        }
        public void Draw(Graphics gr)
        {
            Impl.Draw(gr);
            
        }

        public ChartManager(IChartImplementation impl)
        {
            Impl = impl;
        }
        public void CreateChart(ClusteringResult result)
        {
            Impl.Reset();
            Impl.SetName(result.ResultName);
            Figure.FigureType[] figures = new[] { Figure.FigureType.circle, Figure.FigureType.rectangle, Figure.FigureType.diamond, Figure.FigureType.triangle };
            Color[] colors = new[] { Color.BlueViolet, Color.Blue, Color.Brown, Color.DarkGreen, Color.Yellow };
            for (int i = 0; i < result.Clusters.Count; i++)
            {
                Impl.SetPointType(colors[i % colors.Length], figures[i % figures.Length], 20);
                foreach (var obj in result.Clusters[i].CleanObjects)
                {
                    Impl.SetPoint((float)obj.ObjData[0], (float)obj.ObjData[1]);
                }
            }
        }

      
    }
}
