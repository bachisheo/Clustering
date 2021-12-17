using System.Collections.Generic;
using Clustering.Clusterizators;
using Clustering.src.Managers;

namespace Clustering.Managers
{
    public class ManagerRegistry
    {
        public List<HierarchyManager> Prototypes { get; private set; }
        public ManagerRegistry(List<HierarchyManager> prototypes)
        {
            Prototypes = prototypes;
        }
    }
}