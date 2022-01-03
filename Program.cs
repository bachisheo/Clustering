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
            var manager = new ProcessingManager(new KMeansClusteringManager(2), new DirectNormalizer(), new SQLiteLoader());
            TextBuilder tb = new TextBuilder();
            StreamWriter sw = new StreamWriter("result.txt");
            tb.BuildDataView(manager.Execute("Данные о матче"));
            sw.Write(tb.GetResult());
            sw.Close();
        }
    }
}
