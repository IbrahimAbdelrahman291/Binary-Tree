using System;
using System.Xml.Linq;


namespace Tree
{
    internal class Btree
    {
        Node Root;
        public int count;
        public Btree()
        {
            Root = null;
        }
        public void add(int value)
        {
            if (Root == null)
            {
                Root = new Node(value);
            }
            else
            {
                AddTo(Root, value);
            }
            count++;
        }
        private void AddTo(Node node, int value)
        {
            if (value < node.value)
            {
                if (node.Left == null)
                {
                    node.Left = new Node(value);
                }
                else
                {
                    AddTo(node.Left, value);
                }
            }
            else
            {
                if (node.Right == null)
                {
                    node.Right = new Node(value);
                }
                else
                {
                    AddTo(node.Right, value);
                }
            }
        }

        public void preOrder()
        {
            Console.WriteLine("preOrder:");
            preOrder(Root);
            Console.WriteLine("----------------------");
        }
        private void preOrder(Node node)
        {
            if (node != null)
            {
                Console.WriteLine(node.value);
                preOrder(node.Left);
                preOrder(node.Right);
            }
        }
        public void InOrder()
        {
            Console.WriteLine("InOrder:");
            InOrder(Root);
            Console.WriteLine("----------------------");
        }
        private void InOrder(Node node)
        {
            if (node != null)
            {
                InOrder(node.Left);
                Console.WriteLine(node.value);
                InOrder(node.Right);
            }
        }
        public void postOrder()
        {
            Console.WriteLine("PostOrder:");
            PostOrder(Root);
            Console.WriteLine("----------------------");
        }
        private void PostOrder(Node node)
        {
            if (node != null)
            {
                PostOrder(node.Left);
                PostOrder(node.Right);
                Console.WriteLine(node.value);
            }
        }
        public void search(int value)
        {
            Node Current = Root;
            if (Current.value==value)
            {
                Console.WriteLine("Founded in Root");
            }
            else if (Root==null)
            {
                Console.WriteLine("Tree doesn't has elements");
            }
            else
            {
                while (Current != null)
                {

                    if (value > Current.value)
                    {
                        Current = Current.Right;
                    }
                    else if(value < Current.value)
                    {
                        Current=Current.Left;
                    }
                    else
                    {
                        Console.WriteLine("Founded");
                        return;
                    }
                }
            }
        }
    }
}
