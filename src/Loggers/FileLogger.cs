using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clustering.Objects
{
    public class FileLogger : ILogger
    {
        private static string loggPath = "clust.log";
        private static FileLogger _instance;
        public static ILogger Instance
        {
            get => _instance ??= new FileLogger();
        }

        private StreamWriter _sw;

        public void Log(string info)
        {
            _sw = new StreamWriter(loggPath, true, System.Text.Encoding.UTF8);
            _sw.Write(System.DateTime.Now + " " + info);
            _sw.Close();
        }

    }
}