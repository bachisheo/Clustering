using System;
using System.Collections.Generic;
using Clustering.PlaneChart;

namespace Clustering
{
    /// <summary>
    /// Класс, определяющий структуру снимка, создаваемого ClusterChart'ом
    /// </summary>
    public class ClusterChartMemento
    {
        public string MementoName { get; }
        public string Name { get; }
        public List<Point> Points { get; private set; }
        public List<Figure> ActiveFigures { get; private set; }

        public ClusterChartMemento(String mementoName, String name, List<Point> points, List<Figure> figures)
        {
            MementoName = mementoName;
            Name = name;
            Points = new List<Point>(points);
            ActiveFigures = new List<Figure>(figures);
        }
    }
}