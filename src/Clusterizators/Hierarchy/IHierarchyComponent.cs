using System;
using System.Collections.Generic;

namespace Clustering.Clusterizators.Hierarchy
{
    public interface IHierarchyComponent
    {
        public IHierarchyComponent GetLeftChild();
        public IHierarchyComponent GetRightChild();
        public IHierarchyComponent GetParent();
        public void SetParent(IHierarchyComponent parent);
        public string Info();
        public HierarchyIterator CreateIterator();

    }
}