using Clustering.Objects;

namespace Clustering.Normalizers
{
    public interface INormalizer
    {
        public CleanObject Normalize(RawObject obj, CleanSet newSet);
        public CleanSet Normalize(RawSet data);

        public CleanObject Normalize(CleanObject obj, CleanSet newSet)
        {
            var newObj = obj.Clone();
            newObj.CleanSet = newSet;
            return newObj;
        }

        public CleanSet Normalize(CleanSet data)
        {
            return data.Clone();
        }
    }
}