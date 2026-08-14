using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProblems
{
    internal class Node
    {
        public int Data;
        public Node Next;
        public Node(int value) 
        { 
            Data = value;
            Next = null;
        }
    }
    internal class LinkedList
    {
        public static Node AddNode(Node head, int data)
        {
            Node newNode= new Node(data);
            if (head != null)
            {               
                newNode.Next = head;
            }
            return newNode;
        }
        public static Node Reverse(Node node)
        {
            if (node == null)
                return node;
            if (node.Next == null)
                return node;
            Node prvNode = null;
            while (node.Next != null)
            {
                Node temp= node.Next;
                node.Next = prvNode;
                prvNode = node;
                node = temp;
            }
            node.Next = prvNode;
            return node;
        }
        public static void Display(Node node)
        {
            while (node != null)
            {
                Console.Write("{0}, ",node.Data);
                node = node.Next;
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            Node head = null;
            head = AddNode(head, 1);
            head = AddNode(head, 2);
            head = AddNode(head, 3);
            head = AddNode(head, 4);
            head = AddNode(head, 5);
            Display(head);
            head=Reverse(head);
            Display(head);
        }
    }
}
