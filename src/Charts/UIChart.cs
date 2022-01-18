using Clustering.Objects;
using Clustering.src.Charts;

namespace Clustering.Charts
{
    public class UIChart
    {
        private IChart _chart;

        public UIChart(IChart chart)
        {
            _chart = chart;
        }

        public void CreateChart(ClusteringResult result)
        {
        }
    }
}