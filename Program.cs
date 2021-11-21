using System;
using System.Collections.Generic;
using System.Data;
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
            ClusteringContext db = new ClusteringContext();
            DataSource ds = new DataSource
            {
                SourceName = "DataSet_01"
            };
            ds.RawObjects.Add(new RawObject{ObjData = new double[]{1, 0}});
            ds.RawObjects.Add(new RawObject{ObjData = new double[]{50, 80}});
            ds.RawObjects.Add(new RawObject{ObjData = new double[]{3, 4}});
            ds.RawObjects.Add(new RawObject{ObjData = new double[]{2, 6}});
            ds.RawObjects.Add(new RawObject{ObjData = new double[]{90, 60}});
            db.DataSources.Add(ds);
            db.SaveChanges();
        }

    }
}
