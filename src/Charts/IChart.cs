using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clustering.Objects;

namespace Clustering.src.Charts
{
    public interface IChart
    {
        public void Draw(List<CleanObject> objects, StreamWriter sw);
    }
}
