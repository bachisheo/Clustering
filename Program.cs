using System;
using System.IO;
using System.Windows.Forms;
using Clustering.Builders;
using Clustering.DataBase;
using Clustering.Managers;
using Clustering.Normalizers;
using Clustering.Objects;
using Clustering.src.Managers;

namespace Clustering
{
    static class Program
    {

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
             // RunForms();
              double[][] data = new[]
              {
                  new[] { 1, 2.4 },
                  new[] { 5, 22.4 },
                  new[] { 1000, 2000.4 },
                  new[] { 12, 2.4 },
                  new[] { 700, 200.4 },
        };
            var manager = new ProcessingManager(new KMeansClusteringManager(2), new DirectNormalizer());
            var res =  manager.Execute(data);
            TextBuilder tb = new TextBuilder();
            tb.BuildDataView(res);
            StreamWriter sw = new StreamWriter("result.txt");
            sw.Write(tb.GetResult());
            sw.Close();
        }
    }
}
