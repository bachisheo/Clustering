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
            Logger log = Logger.Instance;
            log.Log("Main program is started");
            ClusteringContext db = new ClusteringContext();
            var rawSet = db.RawSets.First();
            foreach (var rawObj in rawSet.RawObjects)
            {
                Console.WriteLine(rawObj.ObjData[0]);
            }
        }

    }
}
