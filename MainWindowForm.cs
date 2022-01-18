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

    public partial class MainWindowForm : Form, IObserver
    {
        public ChartManager chart;
        public ProcessingManager _manager;
        public IState currentState;
        public List<ClusteringManager> Clusterizers {  get; private set; }
        public List<RawSet> DataSetsList{  get; private set; }
        private MementoKeeper mk;
        private PlaneChart.ClusterChart _clusterChart;
        public void SetState(IState newState)
        {
            currentState = newState;
        }

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
        }

        private void Load1()
        {
            currentState = new ClearState(this);
            Clusterizers = new List<ClusteringManager> { new ClusteringManager(new KMeansAlglibAdapter(2)), new ClusteringManager(new HierarchyClusterizer()) };
            _manager = new ProcessingManager();
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClustering_Click(object sender, EventArgs e)
        {
            try
            {
                _manager.Execute();
            }
            catch(ProcessingManagerException ex)
            {
                MessageBox.Show(ex.Message);
            }
            var tb = new TextBuilder();
            tb.SetName("Результат кластеризации методом " + _manager.Clusterizer.ToString());
            ResultTextBox.Text = tb.GetResult();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
           currentState.DrawResult();
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
            NormalizerBox.Items.Clear();
            foreach (var mem in mk.mems)
            {
                NormalizerBox.Items.Add(mem.MementoName);
            }
            Refresh();
        }

        private void NormalizerBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _clusterChart.SetMemento(mk.mems.Find((x) => x.MementoName == NormalizerBox.SelectedItem.ToString()));
            Refresh();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
