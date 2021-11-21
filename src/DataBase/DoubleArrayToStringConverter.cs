using System;
using System.Linq;

namespace Clustering.DataBase
{
    public static class DoubleArrayToStringConverter 
    {
        private static char separator = '|';
        public static double[] StringToDouble(string s)
        {
            var data = s.Split(separator);
            return data.Select(Double.Parse).ToArray();
        }
        public static string DoubleToString(double[] array)
        {
            string s = "";
            foreach (var d in array)
            {
                s += d;
                s += separator;
            }

            return s;
        }
    }
}