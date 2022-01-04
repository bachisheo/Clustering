using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clustering.Builders;
using Clustering.Charts;
using Clustering.DataBase;
using Clustering.Managers;
using Clustering.Normalizers;
using Clustering.Objects;
using Clustering.PlaneChart;
using Clustering.src.Managers;
using OxyPlot;
using OxyPlot.Series;

namespace Clustering
{

    public partial class MainWindowForm : Form
    {

        private ChartManager _chart;
        public MainWindowForm()
        {
            InitializeComponent();
            ProcessingManager manager = new ProcessingManager(new KMeansClusteringManager(2), 
                new AreaNormalizer(PlaneChartView.Width - 100, PlaneChartView.Height - 100),
                new SQLiteLoader());
            _chart = new ChartManager(new PlaneChart.PlaneChart());
           // _chart = new ChartManager(new OxyPlotImplementation(ClusteringResultPlotView));
            _chart.CreateChart(manager.Execute("Данные со спутника"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonClustering_Click(object sender, EventArgs e)
        {
            var tb = new TextBuilder();
            tb.SetName("Результат кластеризации методом к-средних");
            ResultTextBox.Text = tb.GetResult();

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            var gb = new GraphBuilder();
            gb.SetName("Результат кластеризации");
            this.ClusteringResultPlotView.Model = gb.GetResult();
        }

        private void PlaneChartView_Paint(object sender, PaintEventArgs e)
        {
            _chart.Draw(e.Graphics);
        }
    }
}
