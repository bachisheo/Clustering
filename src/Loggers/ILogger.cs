namespace Clustering.Objects
{
    public interface ILogger
    {
        public static ILogger Instance { get; }

        public void Log(string info);
    }
}