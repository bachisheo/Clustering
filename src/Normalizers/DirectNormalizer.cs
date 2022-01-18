using Clustering.Objects;

namespace Clustering.Normalizers
{
    public class DirectNormalizer : INormalizer
    {
        CleanObject INormalizer.Normalize(RawObject obj, CleanSet newSet)
        {
            return new CleanObject(obj, newSet);
        }

        public CleanSet Normalize(RawSet data)
        {
            CleanSet clean = new CleanSet();
            foreach (var rawObj in data.RawObjects)
            {
                clean.CleanObjects.Add(new CleanObject(rawObj, clean));
            }
            clean.Name = "Нормализованные " +  data.SourceName;
            return clean;
        }
    }
}