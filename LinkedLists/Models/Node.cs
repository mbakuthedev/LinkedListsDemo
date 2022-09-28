using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedLists
{
   public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        public void DisplayNode()
        {
            Console.WriteLine(Data);
        }
    }
}
