using System;
using System.Collections.Generic;
using System.Text;

namespace BinaryTreeExample
{
    public class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Left { get; set; }
        public Node<T> Right { get; set; }
        public Node()
        {

        }
        public Node(T value)
        {
            this.Value = value;
        }
        public override string ToString()
        {
            return $"{Value}";
        }
    }
}
