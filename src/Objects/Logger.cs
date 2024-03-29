﻿using System.IO;
using System.Windows.Forms;

namespace Clustering.Objects
{
    public class Logger
    {
        private static string loggPath = "clust.log";
        private static Logger instance;

        public static Logger Instance
        {
            get { return instance ??= new Logger(); }
        }
        private Logger() { }

        public void Log(string info)
        {
            var sw = new StreamWriter(loggPath, true, System.Text.Encoding.UTF8);
            sw.WriteLine(System.DateTime.Now + " " + info);
            sw.Close();
        }
    }
}