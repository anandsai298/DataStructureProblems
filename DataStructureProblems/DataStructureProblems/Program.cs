// See https://aka.ms/new-console-template for more information
using System;
namespace DataStructureProblems
{
    class program
    {
        public static void Main()
        {
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("1.Add data\n2.AddReversedata\n3.InsertParticularPosition\n4.RemoveFirstNode\n5.RemoveLastNode\n6.Search");
                Console.WriteLine("enter option to display");
                int option=Convert.ToInt32(Console.ReadLine());
                switch(option) 
                {
                    case 1:
                        LinkedList linkedList = new LinkedList();
                        linkedList.Add(56);
                        linkedList.Add(30);
                        linkedList.Add(70);
                        break;
                    case 2:
                        LinkedList linkedList1 = new LinkedList();
                        linkedList1.AddReverseOrder(56);
                        linkedList1.AddReverseOrder(30);
                        linkedList1.AddReverseOrder(70);
                        Console.WriteLine("Display reverseorder");
                        linkedList1.Display();
                        break;
                    case 3:
                        LinkedList linkedList2 = new LinkedList();
                        linkedList2.Add(56);
                        linkedList2.Add(70);
                        linkedList2.Display();
                        linkedList2.InsertParticularPosition(1, 30);
                        Console.WriteLine("Display insertion of data");
                        linkedList2.Display();
                        break;
                    case 4:
                        LinkedList linkedList3 = new LinkedList();
                        linkedList3.Add(56);
                        linkedList3.Add(30);
                        linkedList3.Add(70);
                        linkedList3.Display();
                        linkedList3.RemoveFirstNode();
                        Console.WriteLine("Display after remove of first node data");
                        linkedList3.Display();
                        break;
                    case 5:
                        LinkedList linkedList4 = new LinkedList();
                        linkedList4.Add(56);
                        linkedList4.Add(30);
                        linkedList4.Add(70);
                        linkedList4.Display();
                        linkedList4.RemoveLastNode();
                        Console.WriteLine("Display after remove of last node data");
                        linkedList4.Display();
                        break;
                    case 6:
                        LinkedList linkedList5 = new LinkedList();
                        linkedList5.Add(56);
                        linkedList5.Add(30);
                        linkedList5.Add(70);
                        linkedList5.Display();
                        Console.WriteLine("Display search data of 30");
                        int position = linkedList5.Search(30);
                        Console.WriteLine("Display insert data after 30 is 40");
                        linkedList5.InsertParticularPosition(position+1, 40);
                        linkedList5.Display();
                        break;
                }
            }   
        }
    }
}
