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
            RunForms();
           double[][] data = new[]
           {
               new[] { 1, 2.3 },
               new[] { 2, 2.3 },
               new[] { 2.3, 1.3 }
           };
            var manager = new ProcessingManager(new KMeansClusteringManager(2), new DirectNormalizer(), new SQLiteLoader());
            var set = manager.ConvertData(data);

             TextBuilder tb = new TextBuilder();
            StreamWriter sw = new StreamWriter("result.txt");
            tb.BuildDataView(manager.Execute("������ � �����"));
            sw.Write(tb.GetResult());
            sw.Close();
        }
    }
}
