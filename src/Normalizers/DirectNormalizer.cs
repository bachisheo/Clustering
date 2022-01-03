using Clustering.Objects;

namespace Clustering.Normalizers
{
    public class DirectNormalizer : INormalizer
    {
        CleanObject INormalizer.Normalize(RawObject obj)
        {
            return new CleanObject(obj);
        }

        public CleanSet Normalize(RawSet data)
        {
            CleanSet clean = new CleanSet();
            foreach (var rawObj in data.RawObjects)
            {
                clean.CleanObjects.Add(new CleanObject(rawObj));
            }

            clean.Name = "Нормализованные " +  data.SourceName;
            return clean;
        }

    }
}