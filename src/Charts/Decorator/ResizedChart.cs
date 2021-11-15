using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Text;
using Clustering.Objects;

namespace Clustering.src.Charts
{
    class ResizedChart : IChartDecorator
    {

        private IChart _mainChart;
        private double delta = 100;
        public ResizedChart(IChart mainChart)
        {
            _mainChart = mainChart;
        }
        public void Draw(List<CleanObject> objects, StreamWriter sw)

        {
            List<CleanObject> resizedObj = new List<CleanObject>(objects);
            foreach (var obj in resizedObj)
            {
                for(int i = 0; i < obj.Data.Length; i++)
                {
                    obj.Data[i] *= delta;
                }
            }
            _mainChart.Draw(resizedObj, sw);
        }
    }
}
