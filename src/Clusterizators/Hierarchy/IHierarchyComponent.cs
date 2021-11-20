using System;
using System.Collections.Generic;
using Clustering.Objects;

namespace Clustering.Clusterizators.Hierarchy
{
    public interface IHierarchyComponent
    {
        public IHierarchyComponent GetLeftChild();
        public IHierarchyComponent GetRightChild();
        public IHierarchyComponent GetParent();
        public void SetParent(IHierarchyComponent parent);
        List<CleanObject> GetItems();
        public string Info();

    }
}