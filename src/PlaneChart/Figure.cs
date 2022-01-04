using System.Drawing;

namespace Clustering.PlaneChart
{
    public class Figure
    {
        public enum FigureType
        {
            rectangle,
            circle
        };
        public Color color;
        public int size;
        public FigureType type;

    }
}