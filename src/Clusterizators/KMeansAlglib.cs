using System;
using System.Collections.Generic;
using System.Text;
namespace Clustering.Clusterizators
{
    public class KMeansAlglib : KMeansClusterizator
    {
        KMeansAlglib()
        {
            alglib.clusterizerstate s;
            alglib.kmeansreport rep;
            double[,] xy = new double[,] { { 1, 1 }, { 1, 2 }, { 4, 1 }, { 2, 3 }, { 4, 1.5 } };

            alglib.clusterizercreate(out s);
            alglib.clusterizersetpoints(s, xy, 2);
            alglib.clusterizersetkmeanslimits(s, 5, 0);
            alglib.clusterizerrunkmeans(s, 2, out rep);
            System.Console.WriteLine("{0}", rep.terminationtype); // EXPECTED: 1

        }
    }
}
