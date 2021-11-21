using System;
using System.Globalization;
using System.Linq;
using System.Text;

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
            StringBuilder s = new StringBuilder();
            s.Append(array[0].ToString(CultureInfo.InvariantCulture));
            for(int i = 1; i < array.Length; i++)
            {
                s.Append(separator + array[i].ToString(CultureInfo.InvariantCulture));
            }

            return s.ToString();
        }
    }
}