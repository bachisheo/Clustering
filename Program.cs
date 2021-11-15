using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clustering.Charts;
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
            TestDecorator();
        }

        static void TestDecorator()
        {
            double[] data = { 1, 2, 3, 4, 5, 6, 7};
            var objects = new List<CleanObject>();
            for (int i = 0; i < data.Length; i++)
            {
                double[] tmpData = { data[i]};
                objects.Add(new CleanObject(tmpData));
            }
            StreamWriter sw = new StreamWriter("..\\..\\..\\result.txt", false, System.Text.Encoding.UTF8);
            var charts = new List<IChart>();

            Chart simpleChart = new Chart();
            BorderedChart borderedChart = new BorderedChart(simpleChart);
            charts.Add(simpleChart);
            charts.Add(borderedChart);
            charts.Add(new BorderedChart(borderedChart));
            charts.Add(new ResizedChart(borderedChart));
            foreach (var chart in charts)
            {
                sw.WriteLine();
                chart.Draw(objects, sw);
            }
            sw.Close();

        }

    }
}
