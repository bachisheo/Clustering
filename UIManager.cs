using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using Clustering.Builders;
using Clustering.Clusterizators;
using Clustering.DataBase;
using Clustering.Exceptions;
using Clustering.Managers;
using Clustering.Normalizers;
using Clustering.Objects;
using Clustering.src.Observer;

namespace Clustering
{
    /// <summary>
    /// Главная форма пользовательского интерфейса
    /// </summary>
    public partial class MainWindowForm : Form, IObserver
    {
        public ChartManager chart;
        private ProcessingManager _manager;
        public List<AbstractClusteringManager> Clusterizers {  get; private set; }
        public List<RawSet> DataSetsList{  get; private set; }
        private MementoKeeper mk;
        private PlaneChart.ClusterChart _clusterChart;
     
        /// <summary>
        /// Заполнение окон с выбором параметров кластеризации
        /// </summary>
        private void InitComboBox()
        {
            ClusterizerSetBox.DataSource = Clusterizers;
            var db = new ClusteringContext();
            DataSetsList = new List<RawSet>();
            foreach (var set in db.RawSets)
            {
                DataSetsList.Add(set);
            }
            CleanSetNamesBox.DataSource = DataSetsList;
            ChartMementoBox.DisplayMember = "MementoName";
        }

        /// <summary>
        /// Инициализация основных компонентов системы
        /// </summary>
        private void Load1()
        {
            Clusterizers = new List<AbstractClusteringManager> { new KMeansClusteringManager(2), new DBScanClusteringManager() };
            _manager = new ProcessingManager();
            //нормализатор для корректного отображения объектов на графике
            _manager.Normalizer = new AreaNormalizer(PlaneChartView.Width - 100, PlaneChartView.Height - 100);
            _clusterChart = new PlaneChart.ClusterChart();
            chart = new ChartManager(_clusterChart);
            mk = new MementoKeeper(_clusterChart);

            var events = new EventManager();
            events.Attach(chart);
            events.Attach(mk);
            events.Attach(this);
            _manager.Events.Add(events);

            _manager.Reader = new SQLiteReader();
            var a = GUILogger.Instance as GUILogger;
            a.TextBox = ResultTextBox;
            InitComboBox();
        }

        public MainWindowForm() 
        {
            InitializeComponent();
            Load1();
        }

     

        private void Сlusterize_Button_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.Execute();
                var res = _manager.Clusterizer.LastResult;
                GUILogger.Instance.Log("Данные \"" + res.CleanSet.Name + "\" были кластеризованы методом \"" + _manager.Clusterizer.ToString() + "\"");
            }
            catch(ProcessingManagerException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void buttonDraw_Click(object sender, EventArgs e)
        {
         //  currentState.DrawResult();
        }

        private void PlaneChartView_Paint(object sender, PaintEventArgs e)
        {
           chart.Draw(e.Graphics);
        }
      
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _manager.Clusterizer = ClusterizerSetBox.SelectedItem as AbstractClusteringManager;
            GUILogger.Instance.Log("Выбран метод кластеризации: "+ _manager.Clusterizer.ToString());
        }

        private void CleanSetNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _manager.DataRawSet = CleanSetNamesBox.SelectedItem as RawSet;
            GUILogger.Instance.Log("Выбран набор данных: " + _manager.DataRawSet.SourceName);
        }

        public void Update(ClusteringResult result)
        {
             ChartMementoBox.Items.Clear();
             foreach (var mem in mk.mems)
             {
                 ChartMementoBox.Items.Add(mem);
             }
             Refresh();
        }

        private void ChartMementoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var mem = ChartMementoBox.SelectedItem as ClusterChartMemento;
            if (mem != null)
            {
                _clusterChart.SetMemento(mem);
                GUILogger.Instance.Log("Загружен результат совершенной ранее кластеризации: " + mem.MementoName);
            }
            Refresh();
        }


        private void Export_Button_Click(object sender, EventArgs e)
        {
            var tb = new TextBuilder();
            tb.SetName("Результат кластеризации методом " + _manager.Clusterizer.ToString());
            tb.BuildDataView(_manager.Clusterizer.LastResult);
            var _sw = new StreamWriter("result.txt", true, System.Text.Encoding.UTF8);
            _sw.Write(tb.GetResult());
            _sw.Close();
            GUILogger.Instance.Log("Результат кластеризации экспортирован в файл \"result.txt\"");
        }
    }
}
