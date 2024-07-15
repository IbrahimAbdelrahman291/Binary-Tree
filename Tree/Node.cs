using System;


namespace Tree
{
    internal class Node
    {
        public int value;
        public Node Left;
        public Node Right;
        public Node(int x) 
        {
            value = x;
            Left = null!;
            Right = null!;
        }
    }
}
