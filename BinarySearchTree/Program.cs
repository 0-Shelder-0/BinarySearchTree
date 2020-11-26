using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BinarySearchTree.BinaryTree;

namespace BinarySearchTree
{
    static class Program
    {
        private static void Main()
        {
            var t = new BinaryTree<int, int>();

            var tree = new BinaryTree<int, int>
            {
                {5, 0},
                {2, 0},
                {1, 0},
                {3, 0},
                {7, 0},
                {6, 0},
                {8, 0}
            };
        }
    }
}
