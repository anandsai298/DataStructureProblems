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
            linkedList.AddReverseOrder(70);
            linkedList.AddReverseOrder(30);
            linkedList.AddReverseOrder(50);
        }
    }
}
