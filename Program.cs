using System;
using System.Collections.Generic;

namespace Day_14_Practice_Problem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedList<int> a1 = new LinkedList<int>(); 
            a1.AddLast(56);
            a1.AddLast(30);
            a1.AddLast(70);
            foreach (int data in a1)
            {
                Console.WriteLine( "| " + data + " |");
                Console.WriteLine("-----------------");
            }
        }
    }
}