using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using Clustering.Charts;

namespace Clustering.PlaneChart
{
    public class PlaneChart :IChartImplementation
    {
        private string _name = "";
        private List<Point> _points = new List<Point>();
        public List<Figure> _activeFigures;
        public Figure currentType;
        private bool _isNeedToClear = false;

        public void SetPoint(double x, double y)
        {
            _points.Add(new Point((float)x, (float)y, currentType));
        }

        public void Draw(Graphics gr)
        {
            Brush br = new SolidBrush(Color.Black);
            if (_isNeedToClear)
            {
                var r = gr.ClipBounds;
                br = new SolidBrush(Color.Azure);
                gr.FillRectangle(br, 0, 0, r.Width, r.Height);
                _isNeedToClear = false;
            }
            br = new SolidBrush(Color.Black);
            gr.DrawString(_name, new Font(FontFamily.GenericSansSerif, 14, FontStyle.Regular), br, 0, 0);
            foreach (var point in _points)
            {
                br = new SolidBrush(point.Figure.color);
                float h = gr.ClipBounds.Height;
                switch (point.Figure.type)
                {
                    case Figure.FigureType.rectangle:
                        gr.FillRectangle(br, point.X , h - point.Y - point.Figure.size, point.Figure.size, point.Figure.size);
                        break;
                    case Figure.FigureType.circle:
                        gr.FillEllipse(br, point.X , h - point.Y - point.Figure.size, point.Figure.size, point.Figure.size);
                        break;
                    default:
                        gr.FillPie(br, point.X , h - point.Y - point.Figure.size, point.Figure.size, point.Figure.size, 0, 90);
                        break;
                }
            }
            br.Dispose();

        }
         
        public void SetPointType(Color color, Figure.FigureType type, int size)
        {
            currentType = (new Figure { color = color, type = type, size = size });
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public void Reset()
        {
            _isNeedToClear = true;
            _points.Clear();
        }
    }
}