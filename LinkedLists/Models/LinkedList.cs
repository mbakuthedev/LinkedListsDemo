using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
   public class LinkedList
    {
        public Node First { get; set; }
        public void InsertFirst(int data)
        {
            //Create new node
            Node newNode = new Node();
            //Assign the data
            newNode.Data = data;
            //Assign data to next field
            newNode.Next = First;
            //Assign the head
            First = newNode;
        }
        public Node DeleteFirst()
        {
            Node temp = First;
            First = First.Next;
            return temp;
        }
        public void DisplayList()
        {
            Console.WriteLine("Iterating...");
            Node current = First;
            while (current.Next != null)
            {
                current.DisplayNode();
                current = current.Next;
            }

        }   
        public void InsertLast(int data)
        {
            Node current = First;
            while (current.Next != null)
            {
                current = current.Next;
            }
            Node newNode = new Node();
            newNode.Data = data;
            current.Next = newNode;
        }
    }
}
