using BinarySearchTree.BinaryTree;

namespace BinarySearchTree
{
    static class Program
    {
        private static void Main()
        {
            var tree = new BinaryTree<int, int>();
            tree.Add(5, 0);
            tree.Add(2, 0);
            tree.Add(1, 0);
            tree.Add(3, 0);
            tree.Add(7, 0);
            tree.Add(6, 0);
            tree.Add(8, 0);

            tree.Remove(7);
        }
    }
}
