using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clustering.Charts;
using Clustering.Clusterizators;
using Clustering.Objects;
using Clustering.src.Charts;

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
            Application.Run(new Form1());
        }

        static void Main()
        {
            TestAdapter();
        }

        static void TestAdapter()
        {
                var objects = new List<CleanObject>();
                objects.Add(new CleanObject(new double[] { 1, 0 }));
                objects.Add(new CleanObject(new double[] { 50, 80 }));
                objects.Add(new CleanObject(new double[] { 4, 1 }));
                objects.Add(new CleanObject(new double[] { 2, 1 }));
                objects.Add(new CleanObject(new double[] { 60, 70 }));

                var kmeans = new KMeansAlglibAdapter();
                var clusters = kmeans.Clustering(objects);

            StreamWriter sw = new StreamWriter("..\\..\\..\\result.txt", false, System.Text.Encoding.UTF8);
            var charts = new List<IChart>();
            Chart simpleChart = new Chart();
         
            simpleChart.Draw(clusters, sw);
            sw.Close();

        }

    }
}
