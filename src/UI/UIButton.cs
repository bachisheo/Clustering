using System.Collections.Generic;
using System.IO;
using Clustering.Objects;

namespace Clustering
{
    public class UIButton
    {
        public ICommand Command { private get; set; }
        public string Name { get; private set; }

        public UIButton(string name)
        {
            Name = name;
        }
        public void Click()
        {
            Command.Execute();
        }
    }

    public class UIManager
    {
        private ClusteringManager _clusteringManager;
        private StreamWriter _sw;
        public CleanSet CurrentDataSet;
        public UIButton ClusteringButton { private set; get; }
        public UIButton DrawButton { private set; get; }

        public UIManager(StreamWriter sw, ClusteringManager manager)
        {
            _clusteringManager = manager;
            ClusteringButton = new UIButton("Кластеризовать");
            ClusteringButton.Command = new ClusteringCommand(_clusteringManager);
            DrawButton = new UIButton("Построить график");
            DrawButton.Command = new DrawCommand(_clusteringManager, sw);
        }

        public void LoadData(CleanSet dataSet) => _clusteringManager.CleanSet = dataSet;
    }
}