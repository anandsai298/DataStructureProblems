﻿using System;
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
    }
}
