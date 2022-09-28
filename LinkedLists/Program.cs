using LinkedLists;
using System;

class Program
{
    static void Main(string [] args)
    {
        LinkedList linkedList = new LinkedList();
        linkedList.InsertFirst(1);
        linkedList.InsertFirst(2);
        linkedList.InsertFirst(3);
        linkedList.InsertFirst(4);
        linkedList.DisplayList();
    }
}