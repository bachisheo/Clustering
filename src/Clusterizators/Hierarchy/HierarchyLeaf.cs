﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Clustering.Objects;

namespace Clustering.Clusterizators.Hierarchy
{
    public class HierarchyLeaf : IHierarchyComponent
    {
        private IHierarchyComponent parent;
        private CleanObject baseObj;

        public HierarchyLeaf(CleanObject obj)
        {
            baseObj = obj;
            parent = null;
        }
        public IHierarchyComponent GetLeftChild() =>  null;

        public IHierarchyComponent GetRightChild() => null;
        
        public IHierarchyComponent GetParent() => parent;

        public void SetParent(IHierarchyComponent parent) => this.parent = parent;

        public string Info() => "Leaf";

        public List<CleanObject> GetItems()
        {
            var obj = new List<CleanObject>();
            obj.Add(baseObj);
            return obj;
        }
    }
}
