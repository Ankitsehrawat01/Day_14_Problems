using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Practice_Problem
{
    public class Queue_Ex
    {
        Node rear;
        Node front;
        public void Enqueue(int data)
        {
            Node newnode = new Node(data);
            if (front == null)
            {
                rear = newnode;
                front = rear;
            }
            else
            {
                rear.Next = newnode;
                rear = rear.Next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.Write("| " + temp.data + " |");
                temp = temp.Next;
            }
        }
        public void Dequeue()
        {
            if (this.front == null)
            {
                Console.WriteLine("Queue is empty, deletion is not possible");
                return;
            }
            Console.WriteLine("{0} is element dequeue ", this.front.data);
            this.front = this.front.Next;
        }
    }
}
