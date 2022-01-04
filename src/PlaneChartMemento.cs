using System;
using System.Collections.Generic;
using Clustering.PlaneChart;

namespace Clustering
{
    public class PlaneChartMemento
    {
        public string MementoName { get; }
        public string Name { get; }
        public List<Point> Points { get; private set; }
        public List<Figure> ActiveFigures { get; private set; }

        public PlaneChartMemento(String mementoName, String name, List<Point> points, List<Figure> figures)
        {
            MementoName = mementoName;
            Name = name;
            Points = new List<Point>(points);
            ActiveFigures = new List<Figure>(figures);
        }
    }
}