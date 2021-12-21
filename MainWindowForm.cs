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
using Clustering.Objects;
using Clustering.src.Managers;
using OxyPlot;
using OxyPlot.Series;

namespace Clustering
{
  
    public partial class MainWindowForm : Form
    {
        
        private ClusteringManager _clusteringManager;
        public MainWindowForm()
        {
            _clusteringManager = new KMeansClusteringManager();
            InitializeComponent();

            CleanSet cleanSet = new CleanSet();
            cleanSet.Name = "CleanSetPrototype";
            cleanSet.Add(new CleanObject { ObjData = new[] { 1.9, 2.8 } });
            cleanSet.Add(new CleanObject { ObjData = new[] { 100.0, 232.8 } });
            cleanSet.Add(new CleanObject { ObjData = new[] { 10.9, 5.8 } });
            cleanSet.Add(new CleanObject { ObjData = new[] { 60.0, 100.8 } });
            cleanSet.Add(new CleanObject { ObjData = new[] { 50.1 , 150.4 } });
            _clusteringManager.CleanSet = cleanSet;
            
           
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void buttonClustering_Click(object sender, EventArgs e)
        {
            _clusteringManager.CleanSet.Name = "Данные о погоде";
            _clusteringManager.Clusterize();
            var tb = new TextBuilder();
            tb.SetName("Результат кластеризации методом к-средних");
            tb.BuildDataView(_clusteringManager.LastResult);
            ResultTextBox.Text = tb.GetResult();

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            var gb = new GraphBuilder();
            gb.SetName("Результат кластеризации");
            gb.BuildDataView(_clusteringManager.LastResult);
            this.ClusteringResultPlotView.Model = gb.GetResult();
        }
    }
}
