using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTreeSearch
{

    ///  A class which defines a node consisting of a left connector, an integer item, and a right connector
    public class Node
    {
        public Node leftConnector;   //left connector
        public int item;    //integer data item
        public Node rightConnector;  //right connector

        /// A method which prints a visual representation of a node
        public void PrintNode()
        {
            Console.Write("[");
            Console.Write(item);
            Console.Write("]");
        }
       
    }
}
