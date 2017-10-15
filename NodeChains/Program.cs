using System;

namespace NodeChains
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //create first node.
            Node first = new Node { Value = 3 };

            //Second node
            Node middle = new Node { Value = 5 };


            //linking the two nodes together. 
            first.Next = middle;

            //Third node
            Node last = new Node { Value = 7 };

            middle.Next = last;

            //Iterate and print the values of the node chain
            printList(first);
        }

        private static void printList(Node node)
        {
            while (node != null)
            {
                Console.WriteLine(node.Value);
                node = node.Next;
            }
        }
    }
}
