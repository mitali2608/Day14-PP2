using System;

namespace Day14_PP2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region UC1 Create Stack
            Console.WriteLine("-----------------------UC1----------------------------");
            UC1UC2Stack stack = new UC1UC2Stack();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            #endregion

            Console.WriteLine("------------------------------------------------------");


            #region UC2 peek and pop till empty
            Console.WriteLine("-----------------------UC2----------------------------");
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Printstack();
            stack.Peek();
            stack.Pop();
            stack.EmptyStack();
            #endregion

            Console.WriteLine("------------------------------------------------------");


            #region UC3 Enqueue- Create queue
            Console.WriteLine("-----------------------UC3----------------------------");
            UC3UC4Queue queue = new UC3UC4Queue();
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            #endregion

            Console.WriteLine("------------------------------------------------------");

            #region UC4 Dequeue List
            Console.WriteLine("-------------------------UC4--------------------------");
            Console.WriteLine("enqued list:");
            queue.enqueue(56);
            queue.enqueue(30);
            queue.enqueue(70);
            queue.PrintQueue();
            Console.WriteLine("-------------------------------------------------------");
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            queue.dequeue();
            queue.PrintQueue();
            #endregion

            Console.ReadKey();
        }
    }
}
