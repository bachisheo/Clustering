using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Windows.Forms;
using Clustering.Objects;

namespace Clustering.Clusterizators.Hierarchy
{
    class HierarchyComposite : IHierarchyComponent
    {
        private IHierarchyComponent leftChild, rightChild, parent;
        public void SetChildren(IHierarchyComponent leftChildItem, IHierarchyComponent rightChildItem)
        {
            leftChild = leftChildItem;
            leftChild.SetParent(this);
            rightChild = rightChildItem;
            rightChild.SetParent(this);
        }

        public double[] DistanceBetweenChildren()
        {
            double[] dist = { 1, 2, 3 };
            return dist ;
        }
        public IHierarchyComponent GetLeftChild() => leftChild;

        public IHierarchyComponent GetRightChild() => rightChild;

        public IHierarchyComponent GetParent() => parent;
        public void SetParent(IHierarchyComponent parentItem) => parent = parentItem;


        public HierarchyIterator CreateIterator()
        {
            HierarchyIterator it = new HierarchyIterator(this);
            return it;
        }
        public string Info() => "I'm composite";

    }
}
