using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeExample
{
    public class BST<T> : IEnumerable<T>
        where T : IComparable<T>
    {
        public Node<T> Root { get; set; }
        public BST(ICollection<T> collection)
        {
            foreach (var item in collection)
            {
                Add(item);
            }

        }
        public void Add(T value)
        {
            if (value == null)
                throw new ArgumentNullException();
            var newNode = new Node<T>(value);
            if (Root == null)
            {
                Root = newNode; 
            }
            else
            {
                Node<T> temp = Root;
                Node<T> parent;
                while (true)
                {
                    parent = temp;
                    if(newNode.Value.CompareTo(temp.Value) < 0)
                    {
                        temp = temp.Left;
                        if(temp == null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        temp = temp.Right;
                        if(temp == null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }
        public Node<T> FindMin(Node<T> root)
        {
            var current = root;
            while(current.Left != null)
            {
                current = current.Left;
            }
            return current;
        }
        public Node<T> FindMax(Node<T> root)
        {
            var current = root;
            while(current.Right != null)
            {
                current = current.Right;
            }
            return current;
        }
        public Node<T> FindNode(Node<T> root, T key)
        {
            var current = root;
            if (key == null)
                throw new ArgumentNullException();

            while(key.CompareTo(current.Value) != 0)
            {
                if(key.CompareTo(current.Value) < 0)
                {
                    current = current.Left;
                }
                else if(key.CompareTo(current.Value)  > 0)
                {
                    current = current.Right;
                }
                if(current == null)
                {
                    //throw new ArgumentException("Cant find any node");
                    return default(Node<T>);
                }
            }
            return current;
        }
        public Node<T> Remove(Node<T> root, T key)
        {
            if (root == null)
                return root;
            if(key.CompareTo(root.Value) < 0)
            {
                root.Left = Remove(root.Left, key);
            }
            else if(key.CompareTo(root.Value) > 0)
            {
                root.Right = Remove(root.Right, key);
            }
            else
            {
                if(root.Left == null)
                {
                    return root.Right;
                }
                else if(root.Right == null)
                {
                    return root.Left;
                }
                root.Value = FindMin(root.Right).Value;
                root.Right = Remove(root.Right, root.Value);
            }
            return root;

        }

        public IEnumerator<T> GetEnumerator()
        {
            return GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return new BSTEnumerator<T>(Root);

        }
    }
}
