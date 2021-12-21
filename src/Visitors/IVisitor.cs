using Clustering.Objects;

namespace Clustering.Visitors
{
    public interface IVisitor
    {
        public void Visit(ClusteringResult result);
        public void Visit(Cluster cluster);
        public void Visit(CleanObject cleanObject);

        public void Visit(CleanSet cleanSet)
        {
        }

    }
}