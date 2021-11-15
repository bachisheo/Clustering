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

        public List<CleanObject> GetItems()
        {
            var obj = new List<CleanObject>();
            if (leftChild != null)
                obj.AddRange(leftChild.GetItems());
            if (rightChild != null)
                obj.AddRange(rightChild.GetItems());
            return obj;
        }


        public string Info() => "Composite";

    }
}
