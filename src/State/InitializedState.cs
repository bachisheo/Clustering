using System.Windows.Forms;
using Clustering.Objects;

namespace Clustering
{
    public class InitializedState: IState
    {
        private MainWindowForm _mainform;
        private string _message = "Данная операция недоступна, данные не кластеризованы";
        private string _title = "Ошибка";
        public InitializedState(MainWindowForm mainform)
        {
            _mainform = mainform;
        }
        public void Clusterize()
        {
            _mainform._manager.Execute();
        }

        public void Clear()
        {
            _mainform.SetState(new ClearState(_mainform));
            _mainform.currentState.Clear();
        }

        public void DrawResult()
        {
            MessageBox.Show(_message, _title);
        }

        public void SetClusterizer(ClusteringManager manager)
        {
            _mainform._manager.Clusterizer = manager;
        }

        public void SetData(RawSet dataSet)
        {
            _mainform._manager.DataRawSet = dataSet;
        }
    }
}