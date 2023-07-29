using LinkedList;
using System;

namespace LinkedListProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Linked List operations");
            //LinkedList list = new LinkedList();
            //list.Add(56);
            //list.Add(30);
            //list.Add(70);
            //Console.WriteLine("Add in Reverse Order:");
            //list.AddInReverseOrder(56);
            //list.AddInReverseOrder(30);
            //list.AddInReverseOrder(70);
            //list.Display();
            //Console.WriteLine("Insert:");
            //list.InsertParticularPosition(2, 40);
            //list.Display();
            //Console.WriteLine("Remove first Node:");
            //list.RemoveFirstNode();
            //list.Display();
            //Console.WriteLine("Remove last Node:");
            //list.RemoveLastNode();
            //list.Display();
            //Console.WriteLine("Search");
            //int a = list.Search(30);
            //Console.WriteLine(a);
            //Console.WriteLine("Delete Node");
            //list.DeleteNodeAtParticularPosition(2);

            //LinkedListStack stack = new LinkedListStack();
            //stack.Push(56);
            //stack.Push(30);
            //stack.Push(70);
            ////stack.Display();
            //Console.WriteLine("Peek");
            //stack.Peek();
            //Console.WriteLine("Pop");
            //stack.Pop();
            //stack.Display();

            LinkedListQueue queue = new LinkedListQueue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Display();
            queue.Dequeue();
            queue.Display();
        }
    }
}