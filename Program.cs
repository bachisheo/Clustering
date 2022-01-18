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
            Application.Run(new UIManager());
        }

        static void Main()
        {
            RunForms();
        }
    }
}
