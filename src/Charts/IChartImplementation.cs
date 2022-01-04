using System.Configuration;
using System.Drawing;
using Clustering.PlaneChart;

namespace Clustering.Charts
{
    public interface IChartImplementation
    {
        public void SetName(string name);
        public void Draw(Graphics gr);
        public void SetPoint(double x, double y);
        public void SetPointType(Color color, Figure.FigureType type, int size);
        public void Reset();

    }
}