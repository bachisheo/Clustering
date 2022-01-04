using Clustering.Objects;

namespace Clustering.Normalizers
{
    public interface INormalizer
    {
        public CleanObject Normalize(RawObject obj);
        public CleanSet Normalize(RawSet data);
    }
}