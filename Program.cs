using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clustering.Charts;
using Clustering.Clusterizators;
using Clustering.DataBase;
using Clustering.Objects;
using Clustering.src.Charts;
using Clustering.src.Managers;
using Microsoft.EntityFrameworkCore;
using OxyPlot;
using Console = System.Console;

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
            ClusteringManager manager = new KMeansClusteringManager();
            manager.CleanSet = new CleanSet();
            manager.CleanSet.Add(new CleanObject{ObjData = new []{1.9, 2.8}});
            manager.CleanSet.Add(new CleanObject{ObjData = new []{100.0, 232.8}});
            manager.CleanSet.Add(new CleanObject{ObjData = new []{10.9, 5.8}});
            var res = manager.Clusterize();
            var chart = new ListChart();
            var sw = new StreamWriter("result.txt", false, System.Text.Encoding.UTF8);
            chart.Draw(res, sw);
            sw.Close();

        }

    }
}
