using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clustering.Objects;

namespace Clustering.src.Charts
{
    class BorderedChart : IChartDecorator
    {
        private IChart _mainChart;

        public BorderedChart(IChart mainChart)
        {
            _mainChart = mainChart;
        }
        public void Draw(List<CleanObject> objects, StreamWriter sw)
        {
            sw.Write("{");
            _mainChart.Draw(objects, sw);
            sw.Write("}");
        }

    }
}
