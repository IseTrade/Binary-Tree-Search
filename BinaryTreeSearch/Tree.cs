using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{
    /// A binary tree data structure which uses the concept of nodes as leaves
    class Tree
    {
        //Create the root of the tree
        public Node rootNode;
        private string output;

        //Default constructor which sets the root to null to start
        public Tree()
        {
            rootNode = null;
        }

        /// A method to return us to back to the top of the tree
        public Node GetRootNode()
        {
            return rootNode;
        }

        public void PreOrder(Node Root)
        {
            if (Root != null)
            {
                Console.Write(Root.item + " ");
                PreOrder(Root.leftconnector);
                PreOrder(Root.rightconnector);
            }
        }

        /// A method to find an item in a node
        /// <param name="node"></param>
        /// <param name="searchItem"></param>
        public string FindNode(Node node, int searchItem)
        {
            if (node == null)
            {
                output = "Not Found";
            }
            else if (searchItem.CompareTo(node.item) < 0)
            {
                output = FindNode(node.leftconnector, searchItem);
            }
            else if (searchItem.CompareTo(node.item) > 0)
            {
                output = FindNode(node.rightconnector, searchItem);
            }
            return output;
        }

        /// A method to insert an integer node into the tree
        public void InsertNode(int id)
        {
            Node newNode = new Node();
            newNode.item = id;

            //Begin checking if there is an existing node
            if (rootNode == null)
            {
                rootNode = newNode;
            }
            else
            {
                //Otherwise set the current node to the root node
                Node currentNode = rootNode;

                //Create another node as the start
                Node parentNode;
                while (true)
                {
                    //Set the parent to be the current node
                    parentNode = currentNode;

                    //If the item is less than the current node
                    if (id < currentNode.item)
                    {
                        //Link it to the left section
                        currentNode = currentNode.leftconnector;
                        if (currentNode == null)
                        {
                            parentNode.leftconnector = newNode;
                            return;
                        }
                    }
                    else
                    {
                        //Link it to the right section
                        currentNode = currentNode.rightconnector;
                        if (currentNode == null)
                        {
                            parentNode.rightconnector = newNode;
                            return;
                        }
                    }
                }
            }
        }
    }
}
