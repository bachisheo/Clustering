using Clustering.Objects;

namespace Clustering.Normalizers
{
    public interface INormalizer
    {
        protected CleanObject Normalize(RawObject obj);
        public CleanSet Normalize(RawSet data);
    }
}