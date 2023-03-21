// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructureProblems
{
    class program
    {
        public static void Main()
        {
            LinkedList linkedList = new LinkedList();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //linkedList.Add(70);
            //linkedList.AddReverseOrder(56);
            //linkedList.AddReverseOrder(30);
            //linkedList.AddReverseOrder(70);
            //linkedList.Display();
            //linkedList.Add(56);
            //linkedList.Add(70);
            //linkedList.Display();
            //linkedList.InsertParticularPosition(1,30);
            //linkedList.Display();
            //linkedList.Add(56);
            //linkedList.Add(30);
            //////linkedList.Add(70);
            //linkedList.Display();
            ////linkedList.RemoveFirstNode();
            //linkedList.Display();
            linkedList.Add(56);
            linkedList.Add(30);
            linkedList.Add(70);
            linkedList.Display();
            linkedList.RemoveLastNode();
            linkedList.Display();
        }
    }
}
