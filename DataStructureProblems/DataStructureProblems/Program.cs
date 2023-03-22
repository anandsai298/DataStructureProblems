// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

namespace DataStructureProblems
{
    class program
    {
        public static void Main()
        {
            //LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);
            //linkedList.Display();
            //Console.WriteLine("Display position of search data 30 is");
            //int position = linkedList.Search(30);
            //Console.WriteLine("Display insert data after 30 is 40");
            //linkedList.InsertParticularPosition(position + 1, 40);
            //linkedList.Display();
            //Console.WriteLine("Display position of search data 40 is");
            //int searchDelete = linkedList.Search(40);
            //linkedList.DeleteNodeAtParticularPosition(searchDelete);
            //linkedList.Display();
            LinkedList_Stack stack = new LinkedList_Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(50);
            stack.Display();
        }
    }
}
