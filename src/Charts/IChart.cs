using System;
using System.Collections.Generic;
using System.IO;
using Clustering.Objects;
using OxyPlot;

namespace Clustering.src.Charts
{
    public interface IChart
    {
        public void Draw(CleanObject obj, StreamWriter sw);
        public void Draw(ClusteringResult result, StreamWriter sw);
    }
}
