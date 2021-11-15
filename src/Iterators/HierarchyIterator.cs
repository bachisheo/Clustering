using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Forms;
using Clustering;
using Clustering.Clusterizators.Hierarchy;

namespace Clustering
{
    public class HierarchyIterator : IClusterIterator<IHierarchyComponent>
    {
        private IHierarchyComponent current;
        private readonly IHierarchyComponent root;

        public HierarchyIterator(IHierarchyComponent rootItem)
        {
            root = rootItem;
            current = root;
        }
        public IHierarchyComponent GetNext()
        {
            //post-order traversal
            var parent = current.GetParent();
            if (current == root)
            {
                current = root.GetLeftChild();
                if (current == null)
                {
                    return root;
                }
            }
            else
            {
                while (current == parent.GetRightChild() && parent != root)
                {
                    if (parent == root)
                        throw new NullReferenceException();
                    current = parent;
                    parent = current.GetParent();
                    
                }
                //now 'current' is a left child
                //and all its elements are processed,
                //we turn to the right brother
                current = parent.GetRightChild();
            }
            
            var left = current.GetLeftChild();
            while (left != null)
            {
                current = left;
                left = current.GetLeftChild();
            }
            return current;
        }

        public bool HasNext()
        {
            if (current == null) return false;
            if (current == root) return true;

            //post-order traversal
            var tmp = current;
            var parent = tmp.GetParent();

            while (tmp == parent.GetRightChild())
            {
                if (parent == root)
                    return false;
                tmp = parent;
                parent = tmp.GetParent();
               
            }
            return parent.GetRightChild() != null;
        }
    }
}
