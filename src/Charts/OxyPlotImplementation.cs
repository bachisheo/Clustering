using System;
using System.Drawing;
using Clustering.Objects;
using Clustering.PlaneChart;
using OxyPlot;
using OxyPlot.Series;

namespace Clustering.Charts
{
    public class OxyPlotImplementation : IChartImplementation
    {
        private PlotModel _model;
        private ScatterSeries _currentSeries;
        private OxyPlot.WindowsForms.PlotView _view;
        public OxyPlotImplementation(OxyPlot.WindowsForms.PlotView view)
        {
            _model = new PlotModel();
            view.Model = _model;
            _model.Background = OxyColor.FromRgb(255, 255, 255);
            _view = view;
        }
        public void SetName(string name)
        {
            _model.Title = name;
            _model.TitleFontSize = 8;
        }

        public void Draw(Graphics gr)
        {
        }

        public void SetPoint(double x, double y)
        {
            _currentSeries.Points.Add(new ScatterPoint(x, y));
        }

        public void SetPointType(Color color, Figure.FigureType type, int size)
        {
            MarkerType markerType = type switch
            {
                Figure.FigureType.circle => MarkerType.Circle,
                Figure.FigureType.rectangle => MarkerType.Square,
                _ => MarkerType.Diamond
            };

            _currentSeries = new ScatterSeries
            {
                MarkerType = markerType,
                MarkerFill = OxyColor.FromRgb(color.R, color.G, color.B),
                MarkerSize = size
            };
            _model.Series.Add(_currentSeries);
        }

        public void Reset()
        {
            _model.Series.Clear();
        }
    }
}