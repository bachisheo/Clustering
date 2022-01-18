using System.IO;

namespace Clustering.Objects
{
    public class GUILogger: ILogger
    {
        public System.Windows.Forms.RichTextBox TextBox { get; set; }
        private static GUILogger _instance;
        public static ILogger Instance
        {
            get => _instance ??= new GUILogger();
        }

        private StreamWriter _sw;

        public void Log(string info)
        {
            TextBox.Text += "\n" + System.DateTime.Now + " " + info;
        }

    }
}