using System;
using System.Collections.Generic;
using System.Text;
using Clustering.Objects;
/*FORMAL DESCRIPTION OF FIELDS:
NPoints number of points, >=0
NFeatures       number of variables, >=1
TerminationType completion code:
*-5 if  distance  type is anything different  from
    Euclidean metric

    *-3 for degenerate dataset: a) less than  K distinct
    points, b) K = 0 for non - empty dataset.
  
* +1 for successful completion
  
K               number of clusters
  
C               array[K, NFeatures], rows of the array store centers
  
CIdx            array[NPoints], which contains cluster indexes
  
IterationsCount actual number of iterations performed by clusterizer.
  
    If algorithm performed more than one random restart,
    total number of iterations is returned.
    Energy merit function, "energy", sum  of  squared  deviations
  
from cluster centers
  

    --ALGLIB--
  
Copyright 27.11.2012 by Bochkanov Sergey
*/

namespace Clustering.Clusterizators
{
    /// <summary>
    ///Only for 2d data
    /// </summary>
    public class KMeansAlglib 
    {
        private alglib.clusterizerstate s;
        private alglib.kmeansreport rep;
        public KMeansAlglib()
        {
            alglib.clusterizercreate(out s);
        }
        public alglib.kmeansreport clusterizerrunkmeans(double [,] xy)
        {
            alglib.clusterizersetpoints(s, xy, 2);
            alglib.clusterizersetkmeanslimits(s, 5, 0);
            alglib.clusterizerrunkmeans(s, 2, out rep);
            return rep;
        }
    }
}
