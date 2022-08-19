using System;
using System.Collections.Generic;

namespace Day_14_Practice_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Stack_Ex stackobj = new Stack_Ex();
            stackobj.Push(70);
            stackobj.Push(30);
            stackobj.Push(56);
            stackobj.Display();
            stackobj.Peek();
            stackobj.Pop();
            stackobj.Display();
            stackobj.Peek();
            stackobj.Pop();
            stackobj.Display();
            stackobj.IsEmpty();

            //Linkedlist a1 = new Linkedlist();
            //a1.AddNode(56);
            //a1.AddNode(30);
            //a1.AddNode(70);
            //a1.Display();

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