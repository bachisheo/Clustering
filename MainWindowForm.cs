using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Clustering.Builders;
using Clustering.Clusterizators;
using Clustering.Clusterizators.Hierarchy;
using Clustering.DataBase;
using Clustering.Managers;
using Clustering.Normalizers;
using Clustering.Objects;
using Clustering.src.Managers;

namespace Clustering
{

    public partial class MainWindowForm : Form
    {
        
        public ChartManager chart;
        public ProcessingManager manager;
        public IState currentState;
        public List<ClusteringManager> Clusterizers {  get; private set; }
        public List<CleanSet> DataSetsList{  get; private set; }

        public void SetState(IState newState)
        {
            currentState = newState;
        }

        private void InitComboBox()
        {
            foreach (var clusterizer in Clusterizers)
            {
                ClusterizerSetBox.Items.Add(clusterizer.ClusterInfo);
            }
            var db = new ClusteringContext();

            DataSetsList = new List<CleanSet>();
            foreach (var set in db.CleanSets)
            {
                DataSetsList.Add(set);
                CleanSetNamesBox.Items.Add(set.Name);
            }
        }
        public MainWindowForm()
        {
            
            InitializeComponent();
            currentState = new ClearState(this);
            Clusterizers = new List<ClusteringManager> {new KMeansClusteringManager(2), new HierarchyManager()};

            manager = new ProcessingManager();
            manager.DbLoader = new SQLiteLoader();

            
            InitComboBox();

         
            /*   manager = new ProcessingManager(new KMeansClusteringManager(2), 
                   new AreaNormalizer(PlaneChartView.Width - 100, PlaneChartView.Height - 100),
                   new SQLiteLoader());
               chart = new ChartManager(new PlaneChart.PlaneChart());
               
               chart.CreateChart(manager.Execute("Данные со спутника"));
            */

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClustering_Click(object sender, EventArgs e)
        {
            currentState.Clusterize();
            var tb = new TextBuilder();
            tb.SetName("Результат кластеризации методом к-средних");
            ResultTextBox.Text = tb.GetResult();

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
           currentState.DrawResult();
        }

        private void PlaneChartView_Paint(object sender, PaintEventArgs e)
        {
           // chart.Draw(e.Graphics);
        }
        public ClusteringManager GetClusterizer(string clusterizerName)
        {
            return Clusterizers.Find((x) => x.ClusterInfo == clusterizerName);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentState.SetClusterizer(GetClusterizer(ClusterizerSetBox.SelectedItem.ToString()));
          
        }

        private void CleanSetNamesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentState.SetData(manager.DbLoader.GetSetByName(CleanSetNamesBox.SelectedItem.ToString()));
        }
    }
}
