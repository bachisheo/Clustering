using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Clustering.Builders;
using Clustering.Clusterizators;
using Clustering.Clusterizators.Hierarchy;
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
        public List<ClusteringManager> Clusterizers {  get; private set; }
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
            Clusterizers = new List<ClusteringManager> { new ClusteringManager(new KMeansAlglibAdapter(2)), new ClusteringManager(new HierarchyClusterizer()) };
            _manager = new ProcessingManager();
            //нормализатор для корректного отображения объектов на графике
            _manager.Normalizer = new AreaNormalizer(PlaneChartView.Width - 100, PlaneChartView.Height - 100);
            _clusterChart = new PlaneChart.ClusterChart();
            chart = new ChartManager(_clusterChart);
            mk = new MementoKeeper(_clusterChart);
            var events = new EventManager();
            events.Attach(chart);
            events.Attach(this);
            events.Attach(mk);
            _manager.Events.Add(events);
            _manager.Reader = new SQLiteReader();
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
                if(_manager.Clusterizer.ToString() == 
                _manager.Execute();
                var tb = new TextBuilder();
                tb.SetName("Результат кластеризации методом " + _manager.Clusterizer.ToString());
                ResultTextBox.Text = tb.GetResult();
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
            _manager.Clusterizer = ClusterizerSetBox.SelectedItem as ClusteringManager;
        }

        private void CleanSetNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _manager.DataRawSet = CleanSetNamesBox.SelectedItem as RawSet;
        }

        public void Update(EventType eventType, ClusteringResult result)
        {
             ChartMementoBox.Items.Clear();
             foreach (var mem in mk.mems)
             {
                 ChartMementoBox.Items.Add(mem);
             }
             Refresh();
        }

        private void NormalizerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clusterChart.SetMemento(ChartMementoBox.SelectedItem as PlaneChartMemento);
            Refresh();
        }
    }
}
