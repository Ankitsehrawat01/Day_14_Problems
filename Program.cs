using System;
using System.Collections.Generic;

namespace Day_14_Practice_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Queue_Ex queueobj = new Queue_Ex();
            queueobj.Enqueue(56);
            queueobj.Enqueue(30);
            queueobj.Enqueue(70);
            queueobj.Display();
            queueobj.Dequeue();
            queueobj.Display();

            //Stack_Ex stackobj = new Stack_Ex();
            //stackobj.Push(70);
            //stackobj.Push(30);
            //stackobj.Push(56);
            //stackobj.Display();
            //stackobj.Peek();
            //stackobj.Pop();
            //stackobj.Display();
            //stackobj.Peek();
            //stackobj.Pop();
            //stackobj.Display();
            //stackobj.IsEmpty();

            //Linkedlist linkedlistobj = new Linkedlist();
            //linkedlistobj.AddNode(56);
            //linkedlistobj.AddNode(30);
            //linkedlistobj.AddNode(70);
            //linkedlistobj.Display();

            //LinkedList<int> a1 = new LinkedList<int>();
            //a1.AddLast(56);
            //a1.AddLast(30);
            //a1.AddLast(70);
            //foreach (int data in a1)
            //{
            //    Console.WriteLine( "| " + data + " |");
            //    Console.WriteLine("-----------------");
            //}
        }
    }
}