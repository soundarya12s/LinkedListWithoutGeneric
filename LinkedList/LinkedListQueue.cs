using LinkedListProblem;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListQueue
    {
        Node head = null;
        internal void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("'{0}' is pushed to Queue", node.data);
            }

        }

        internal void Display()
        {
            Console.WriteLine("\nDisplaying Queue:");
            Node temp = head;
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
            Console.WriteLine("\n");

        }

        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("queue is empty, deletion is not possible!");
                return;
            }
            else
            {
                while (head != null)
                {
                    Console.WriteLine("Value dequeued is: {0}", head.data);

                    head = head.next;
                    break;
                }
            }

        }
    }
}
