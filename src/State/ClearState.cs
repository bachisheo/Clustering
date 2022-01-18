using System.Windows.Forms;
using Clustering.DataBase;
using Clustering.Managers;
using Clustering.Objects;

namespace Clustering
{
    public class ClearState : IState
    {
        private string _message = "Данная операция недоступна, не все поля инициализированы";
        private string _title = "Ошибка";
        private MainWindowForm _mainform;
        public ClearState(MainWindowForm mainform)
        {
            _mainform = mainform;
        }
        public void Clusterize()
        {
            if (_mainform._manager.CheckParams())
            {
                _mainform.SetState(new InitializedState(_mainform));
                _mainform.currentState.Clusterize();
                return;
            }
        }

        public void Clear()
        {
            _mainform._manager = new ProcessingManager();
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