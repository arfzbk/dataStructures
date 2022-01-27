using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryTreeExample
{
    public class BinaryTree<T> where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        public List<Node<T>> list { get; set; }
        public BinaryTree()
        {
            list = new List<Node<T>>(); 
        }
        //InOrder
        public List<Node<T>> InOrder(Node<T> root)
        {
            if(root != null)
            {
                InOrder(root.Left);
                list.Add(root);
                InOrder(root.Right);
            }
            return list;
        }
        //PreOrder
        public List<Node<T>> PreOrder(Node<T> root)
        {
            if(root != null)
            {
                list.Add(root);
                PreOrder(root.Left);
                PreOrder(root.Right);
            }
            return list;
        }
        //PostOrder
        public List<Node<T>> PostOrder(Node<T> root)
        {
            if(root != null)
            {
                PostOrder(root.Left);
                PostOrder(root.Right);
                list.Add(root);
            }
            return list;
        }
        //InOrderNonRecursiveTraversal
        public List<Node<T>> InOrderNonRecursiveTraversal(Node<T> root)
        {
            var s = new Stack<Node<T>>();
            Node<T> currentNode = root;
            bool done = false;
            while (!done)
            {
                if(currentNode != null)
                {
                    s.Push(currentNode);
                    currentNode = currentNode.Left;
                }
                else
                {
                    if(s.Count == 0)
                    {
                        done = true;
                    }
                    else
                    {
                        currentNode = s.Pop();
                        list.Add(currentNode);
                        currentNode = currentNode.Right;
                    }
                }
            }
            return list;
        }
        //PreOrderNonRecursiveTraversal
        public List<Node<T>> PreOrderNonRecursiveTraversal(Node<T> root)
        {
            var s = new Stack<Node<T>>();
            if (root == null)
                throw new ArgumentNullException("Root is null");
            s.Push(root);
            while(s.Count != 0)
            {
                var temp = s.Pop();
                list.Add(temp);
                if (temp.Right != null)
                    s.Push(temp.Right);
                if (temp.Left != null)
                    s.Push(temp.Left);
            }
            return list;
        }
        //LevelOrderNonRecursiveTraversal
        public List<Node<T>> LevelOrderNonRecursiveTraversal(Node<T> root)
        {
            var Q = new Queue<Node<T>>();
            if (root == null)
                throw new ArgumentNullException("Root is null");
            Q.Enqueue(root);
            while(Q.Count != 0)
            {
                var temp = Q.Dequeue();
                list.Add(temp);
                if (temp.Right != null)
                    Q.Enqueue(temp.Right);
                if (temp.Left != null)
                    Q.Enqueue(temp.Left);
            }
            return list;
        }
        //ClearList
        public void ClearList() => list.Clear();
        //MaxDepth
        public static int MaxDepth(Node<T> root)
        {
            if (root == null)
                return 0;
            return Math.Max(MaxDepth(root.Left), MaxDepth(root.Right)) + 1;

        }
        //DeepestNode
        public Node<T> DeepestNode()
        {
            var list = LevelOrderNonRecursiveTraversal(Root);
            return list[list.Count - 1];
        }
        //NumberOfLeafs
        public static int NumberOfLeafs(Node<T> root)
        {
            if (root == null)
                return 0;
            return new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root).Where(l => l.Left == null && l.Right == null).ToList().Count;
        }
        //NumberOfFullNodes
        public static int NumberOfFullNodes(Node<T> root)
        {
            if (root == null)
                return 0;
            return new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root).Where(n => n.Left != null && n.Right != null).ToList().Count;
        }
        //NumberOfHalfNodes
        public static int NumberOfHalfNodes(Node<T> root)
        {
            if (root == null)
                return 0;
            return new BinaryTree<T>().LevelOrderNonRecursiveTraversal(root).Where(n => (n.Left != null && n.Right == null) || (n.Left == null && n.Right != null)).ToList().Count;
        }


    }
}
