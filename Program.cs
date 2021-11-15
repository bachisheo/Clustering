using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clustering.Clusterizators.Hierarchy;
using Clustering.Objects;

namespace Clustering
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void RunForms()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        static void Main()
        {
            TestComposite();
        }


        static void TestComposite()
        {
            double[] rawData = { 1, 2, 3, 4, 5, 6, 7 };
            List<IHierarchyComponent> component = new List<IHierarchyComponent>();
            foreach (var data in rawData)
            {
                double[] nums = { data };
                component.Add(new HierarchyLeaf(new CleanObject(nums)));
            }

            List<HierarchyComposite> composites = new List<HierarchyComposite>(6);
            HierarchyComposite root = new HierarchyComposite();
            HierarchyComposite left = new HierarchyComposite();
            HierarchyComposite leftLeft = new HierarchyComposite();
            HierarchyComposite right = new HierarchyComposite();

            int leafIt = 0;
            root.SetChildren(left, right);
            left.SetChildren(leftLeft, component[leafIt++]);
            leftLeft.SetChildren(component[leafIt++], component[leafIt++]);
            right.SetChildren(component[leafIt++], component[leafIt++]);
            
            component.Add(root);
            component.Add(left);
            component.Add(leftLeft);
            Console.WriteLine("Get data from all components:");

            foreach (var comp in component)
            {
                String s = "";
                foreach (var obj in comp.GetItems())
                {
                    s += obj.Data[0] + " ";
                }
                Console.WriteLine(comp.Info() + ", Data:" + s);

            }

        }

 
    }
}
