using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace Clustering.Objects
{
    public class Logger
    {
        private static string loggPath = "clust.log";
        private static Logger instance;
        private StreamWriter _sw;
        private StringBuilder _sb;
        private static int _sizeToUpdate = 300;
        public static Logger Instance
        {
            get { return instance ??= new Logger(); }
        }

        private Logger()
        {
            _sb = new StringBuilder();
        }

        public void Log(string info)
        {
            _sb.AppendLine(System.DateTime.Now + " " + info);
            if (_sb.Length >= _sizeToUpdate)
            {
                Update();
            }
        }

        public void Update()
        {
            _sw ??= new StreamWriter(loggPath, true, System.Text.Encoding.UTF8);
            _sw.Write(_sb.ToString());
            _sb.Clear();
        }
        ~Logger()
        {
            Update();
            _sw.Close();
        }
    }
}