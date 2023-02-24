using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public  class LinkedList
    {
        public Node head;

        public void Add(int data)
        {
            Node node = new Node(data);

            if(this.head == null) 
            {
                this.head =  node;
            }
            else 
            {
                Node temp = head;
                while (temp.next != null) 
                {
                    temp = temp.next;

                }
                temp.next = node;

            }
            Console.WriteLine("{0} insert into linked List ", node.data);

        }

        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;

            }

            while (temp != null)
            {

                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }



        public Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid Position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                while (position-- != 0)
                {
                    if (position == 1)
                    {
                        Node node = new Node(data);
                        node.next = this.head.next;
                        head.next = node;
                        break;
                    }
                    head = head.next;
                }
                if (position != 1)
                {
                    Console.WriteLine("Position out of range");

                }
            }
            Console.WriteLine("After Inserting value in Linkedlist ");
            

            return head;
        }

        public Node RemoveFirstNode()
        {
            if (this.head == null)
            {

                return null;
            }
            Console.WriteLine("When Remove first element");
            this.head = this.head.next;
            return this.head;
        }








    }
}
