namespace Clustering.PlaneChart
{
    public class Point
    {
        public float X { get; private set; }
        public float Y { get; private set; }
        public Figure Figure { get; private set; }

        public Point(float x, float y, Figure type)
        {
            X = x;
            Y = y;
            Figure = type;
        }
    }
}