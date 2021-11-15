using System;
using System.Collections.Generic;
using System.IO;
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
            TestIteratorAndComposite();
        }


        static void TestIteratorAndComposite()
        {
            double[] rawData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<IHierarchyComponent> component = new List<IHierarchyComponent>();
            foreach (var data in rawData)
            {
                double[] nums = { data };
                component.Add(new HierarchyLeaf(new CleanObject(nums)));
            }

            List<HierarchyComposite> composite = new List<HierarchyComposite>(6);
            for (int i = 0; i < composite.Capacity; i++)
            {
                composite.Add(new HierarchyComposite());
            }

            composite[0].SetChildren(composite[1], composite[4]);
            composite[1].SetChildren(composite[2], composite[3]);
            composite[2].SetChildren(composite[5], component[0]);
            for (int i = 3, leafIt = 1; i < composite.Count; i++)
            {
                composite[i].SetChildren(component[leafIt++], component[leafIt++]);
            }
            StreamWriter sw = new StreamWriter("..\\..\\..\\result.txt", false, System.Text.Encoding.UTF8);
            sw.WriteLine("\nIterate from leaf:");
            HierarchyIterator it = component[0].CreateIterator();
            while (it.HasNext())
            {
                sw.WriteLine(it.GetNext().Info());
            }

            sw.WriteLine("\nIterate from root:");
            it = composite[0].CreateIterator();
            while (it.HasNext())
            {
                sw.WriteLine(it.GetNext().Info());
            }


            sw.WriteLine("\nIterate from node:");
            it = composite[^1].CreateIterator();

            while (it.HasNext())
            {
                sw.WriteLine(it.GetNext().Info());
            }
            sw.Close();
        }

        static void TestTree()
        {
            double[] rawData = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            List<IHierarchyComponent> comp = new List<IHierarchyComponent>();
            foreach (var data in rawData)
            {
                double[] nums = { data };
                comp.Add(new HierarchyLeaf(new CleanObject(nums)));
            }

            List<HierarchyComposite> composites = new List<HierarchyComposite>(6);
            HierarchyComposite root = new HierarchyComposite();
            HierarchyComposite left = new HierarchyComposite();
            HierarchyComposite leftLeft = new HierarchyComposite();
            HierarchyComposite leftRight = new HierarchyComposite();
            HierarchyComposite rightLeft = new HierarchyComposite();
            HierarchyComposite right = new HierarchyComposite();
            root.SetChildren(left, right);
            left.SetChildren(leftLeft, leftRight);
            int leafIt = 0;
            leftLeft.SetChildren(comp[leafIt++], comp[leafIt++]);
            leftRight.SetChildren(comp[leafIt++], comp[leafIt++]);
            rightLeft.SetChildren(comp[leafIt++], comp[leafIt++]);
            right.SetChildren(rightLeft, comp[leafIt++]);


            HierarchyIterator it = root.CreateIterator();
            while (it.HasNext())
            {
                Console.WriteLine(it.GetNext().Info());
            }
            comp.Add(root);
            comp.Add(left);
            comp.Add(right);
            foreach (var component in comp)
            {
                Console.WriteLine(component.Info());
            }
        }
    }
}
