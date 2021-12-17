using System.IO;
using Clustering.Objects;
using Clustering.src.Charts;

namespace Clustering
{
    public interface ICommand
    {
        public void Execute();
    }

    public class ClusteringCommand : ICommand
    {
        public ClusteringManager _manager;
        public ClusteringCommand(ClusteringManager manager)
        {
            _manager = manager;
        }
        public void Execute()
        {
            _manager.Clusterize();
            Logger logger = Logger.Instance;
            logger.Log("Выполняется команда кластеризации");
        }
    }
    public class DrawCommand : ICommand
    {
        private ClusteringManager _clusteringManager;
        private StreamWriter _sw;
        public DrawCommand(ClusteringManager manager, StreamWriter sw )
        {
            _clusteringManager = manager;
            _sw = sw;
        }
        public void Execute()
        {
            Logger logger = Logger.Instance;
            logger.Log("Выполняется команда построения графиков");
            _clusteringManager.Draw(_sw);
         
        }
    }
}