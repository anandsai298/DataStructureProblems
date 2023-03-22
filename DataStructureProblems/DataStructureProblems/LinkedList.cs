using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node=new Node(data);
            if (this.head==null)
            {
                this.head=node;
            }
            else
            {
                Node temp = head;
                while(temp.next!=null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into LinkedList",node.data);
        }
        public void AddReverseOrder(int data) 
        {
            Node newnode=new Node(data);
            if (this.head == null)
             {
                this.head = newnode;
             }
            else
            {
                Node temp = this.head;
                head = newnode;
                head.next = temp;
            }
        }
        public void Display()
        {
            Node temp = this.head;
            if(temp ==null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while(temp!=null)
            {
                Console.WriteLine(temp.data+" ");
                temp= temp.next;
            }
        }
        public void InsertParticularPosition(int position,int data)
        {
            Node newstnode=new Node(data);
            if(this.head==null)
            {
                this.head=newstnode;
            }
            if(position==0)
            {
                newstnode.next=this.head;
                this.head = newstnode;
                return;
            }
            Node prev = null;
            Node current = this.head;
            int count = 0;
            while(current!=null && count<position) 
            {
                prev = current;
                current= current.next;
                count++;
            }
            newstnode.next = prev.next;
            prev.next= newstnode;
        }
        public void RemoveFirstNode()
        {
            if(this.head==null)
            {
                Console.WriteLine("LinkedList is empty");
            }
            this.head = this.head.next;
        }
        public void RemoveLastNode()
        {
            if (this.head==null)
            {
                Console.WriteLine("Linked List is empty");
            }
            if (head.next==null)
            {
                this.head = null;
            }
            Node NewNode = head;
            while(NewNode.next.next !=null)
            {
                NewNode=NewNode.next;
            }
            NewNode.next = null;
        }
        public int Search(int value)
        {
            Node node = this.head;
            int count = 0;
            while (node!=null)
            {
                if(node.data==value)
                {
                    Console.WriteLine(count);
                    return count;
                }
                node = node.next;
                count++;
            }
            return count;
        }
        public void DeleteNodeAtParticularPosition(int position)
        {
            if (this.head==null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            Node temp= this.head;
            if(position==0)
            {
                this.head = temp.next;
                return;
            }
            for(int i=0;temp!=null && i<position-1;i++)
            {
                temp=temp.next;
            }
            if (temp==null || temp.next==null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
            Size();
        }
        public void Size()
        {
            Node temp = this.head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine("Length of LinkedList is :" + count);
        }
    }
}
