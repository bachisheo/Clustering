using System;
using System.Text;
using Clustering.Objects;
using Clustering.Visitors;

namespace Clustering.Builders
{
    public class TextBuilder: IViewBuilder
    {
        private StringBuilder sb;

        public TextBuilder()
        {
            sb = new StringBuilder();
        }
        public void Reset()
        {
            sb = new StringBuilder();
        }

        public void BuildDataView(ClusteringResult res)
        {
            BuildDataView(res.CleanSet);
            var converter = new ConverterToTxt();
            sb.Append("\n");
            sb.Append(converter.Convert(res));
        }

        public void SetName(string name)
        {
            sb.Append( name);
        }

        private void BuildDataView(CleanSet cleanSet)
        {
            var converter = new ConverterToTxt();
            sb.Append("\nИсходный набор данных:\n");
            sb.Append(converter.Convert(cleanSet));
        }


        public string GetResult()
        {
            return sb.ToString();
        }
    }
}