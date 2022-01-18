using System;
using System.IO;
using System.Windows.Forms;
using Clustering.Builders;
using Clustering.Clusterizators;
using Clustering.DataBase;
using Clustering.Managers;
using Clustering.Normalizers;

namespace Clustering
{
    static class Program
    {
        [STAThread]
        static void RunForms()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainWindowForm());
        }

        static void Main()
        {
            RunForms();
           double[][] data = new[]
           {
               new[] { 1, 2.3 },
               new[] { 2, 2.3 },
               new[] { 2.3, 1.3 }
           };
            var manager = new ProcessingManager(new ClusteringManager(new KMeansAlglibAdapter(2)), new DirectNormalizer(), new SQLiteReader());
     

             TextBuilder tb = new TextBuilder();
            StreamWriter sw = new StreamWriter("result.txt");
           // tb.BuildDataView(manager.Execute("Данные о матче"));
            sw.Write(tb.GetResult());
            sw.Close();
        }
    }
}
