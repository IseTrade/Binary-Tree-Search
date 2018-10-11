using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create our tree object
            Tree bst = new Tree();           
            Console.WriteLine("Begin Insertion");

            Separator();

            bst.InsertNode(45);
            bst.InsertNode(17);
            bst.InsertNode(40);
            bst.InsertNode(26);
            bst.InsertNode(15);
            bst.InsertNode(70);
            bst.InsertNode(38);
            bst.InsertNode(80);
            bst.InsertNode(44);
            bst.InsertNode(10);
            bst.InsertNode(19);


            Console.WriteLine("Pre-Order Traversal: ");
            bst.PreOrder(bst.GetRootNode());

            Separator();           

            Console.WriteLine("Finished!");           

            Console.ReadLine();
            
        }

        private static void Separator()
        {
            Console.WriteLine("\n");
        }
    }
}
