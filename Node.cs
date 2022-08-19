using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_14_Practice_Problem
{
    public class Node
    {
        public int data;
        public Node Next;
        public Node(int data)
        {
            this.data = data;
            Next = null;
        }
    }
}
