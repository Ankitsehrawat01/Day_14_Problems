using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Practice_Problem
{
    public class Stack_Ex
    {
        Node top;
        public Stack_Ex()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node newnode = new Node(data);
            newnode.Next = top;
            top = newnode;
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Node temp = top;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.Next;
            }
        }
        public void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            Console.WriteLine("{0} is the topmost element in the stack ", top.data);
        }
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            this.top = top.Next;
        }
        public void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            Console.WriteLine("Stack is empty");
        }

    }
}
