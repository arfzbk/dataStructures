using System;
using System.Collections.Generic;

namespace BinaryTreeExample
{
    public class Program
    {
       public static void Main(string[] args)
        {
            /*var BST = new BST<int>(new List<int>() { 60, 40, 70, 20, 45, 65, 85 });
            var bt = new BinaryTree<int>();

            bt.InOrder(BST.Root)
                .ForEach(node => Console.Write($"{node,-3} "));

            BST.Remove(BST.Root, 20);
            BST.Remove(BST.Root, 40);
            BST.Remove(BST.Root, 60);

            Console.WriteLine();
            bt.ClearList();

            bt.InOrder(BST.Root)
               .ForEach(node => Console.Write($"{node,-3} "));


            Console.WriteLine();

            Console.WriteLine($"Minimum value : {BST.FindMin(BST.Root)}");
            Console.WriteLine($"Maximum value : {BST.FindMax(BST.Root)}");

            var keyNode = BST.FindNode(BST.Root, 100);

            if (keyNode != null)
                Console.WriteLine($"{keyNode.Value} - " +
                $"Left: {keyNode.Left.Value} - " +
                $"Right : {keyNode.Right.Value}");

            //MaxDepth

            var bst = new BST<byte>(new byte[] { 60, 40, 70, 20, 45, 65, 85, 90 });

            var list = new BinaryTree<byte>().InOrder(bst.Root);

            foreach (var node in list)
            {
                Console.Write($"{node,-3} ");
            }
            Console.WriteLine();
            Console.WriteLine($"Min     : {bst.FindMin(bst.Root)}");
            Console.WriteLine($"Max     : {bst.FindMax(bst.Root)}");
            Console.WriteLine($"Depth   : {BinaryTree<byte>.MaxDepth(bst.Root)}");

            //DeepestNode
            var bt = new BinaryTree<char>();
            bt.Root = new Node<char>('F');
            bt.Root.Left = new Node<char>('A');
            bt.Root.Right = new Node<char>('T');
            bt.Root.Left.Left = new Node<char>('D');

            var list = bt.LevelOrderNonRecursiveTraversal(bt.Root);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine();
            Console.WriteLine($"Deepest Node        : " +
                $"{bt.DeepestNode(bt.Root)}");
            Console.WriteLine($"Deepest Node        : " +
                $"{bt.DeepestNode()}");
            Console.WriteLine($"Max. Depth          : " +
                $"{BinaryTree<char>.MaxDepth(bt.Root)}");
            */

            //NumberOfFullNodesandHalfNodes

            var bst = new BST<int>(new int[] { 23, 16, 45, 3, 22, 37, 99 });
            bst.Remove(bst.Root, 3);
            bst.Remove(bst.Root, 99);

            Console.WriteLine($"Number of leafs         : " +
                $"{BinaryTree<int>.NumberOfLeafs(bst.Root)}");

            Console.WriteLine($"Number of full nodes    : " +
                $"{BinaryTree<int>.NumberOfFullNodes(bst.Root)}");

            Console.WriteLine($"Number of half nodes    : " +
                $"{BinaryTree<int>.NumberOfHalfNodes(bst.Root)}");

        }
    }
}
