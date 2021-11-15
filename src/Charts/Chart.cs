using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Clustering.Objects;
using Clustering.src.Charts;

namespace Clustering.Charts
{
    class Chart : IChart
    {
        

        public void Draw(List<CleanObject> objects, StreamWriter sw)
        {
            foreach (var obj in objects)
            {
                foreach (var dat in obj.Data)
                {
                    sw.Write(dat + " ");
                }
            }
        }
    }
}
