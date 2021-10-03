using System;
using System.Collections.Generic;
using System.Text;

namespace Day14_PP2
{
    class UC3UC4Queue
    {
        Node head, tail;

        public void Queue()
        {
            this.head = this.tail = null;
        }

        public void enqueue(int key)
        {


            Node temp = new Node(key);


            if (this.tail == null)
            {
                this.head = this.tail = temp;
                return;
            }


            this.tail.next = temp;
            this.tail = temp;

        }


        public void dequeue()
        {

            if (this.head == null)
                return;


            Node temp = this.head;
            this.head = this.head.next;


            if (this.head == null)
                this.tail = null;
            Console.WriteLine("Head is removed");
        }

        internal void PrintQueue()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }

            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }


        }

    }
}
