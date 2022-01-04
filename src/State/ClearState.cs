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
            MessageBox.Show(_message, _title);
        }

        public void Clear()
        {
            _mainform.manager = new ProcessingManager();
        }

    
        public void DrawResult()
        {
            MessageBox.Show(_message, _title);
        }

        public void SetClusterizer(ClusteringManager manager)
        {
            _mainform.manager.Clusterizer = manager;
            if(_mainform.manager.IsAllParamsInitialized())
                _mainform.SetState(new InitializedState(_mainform));
        }

        public void SetData(CleanSet dataSet)
        {
            _mainform.manager.Clusterizer.CleanSet = dataSet;
            if (_mainform.manager.IsAllParamsInitialized())
                _mainform.SetState(new InitializedState(_mainform));
        }
    }
}