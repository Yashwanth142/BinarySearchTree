namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(70);
            binaryTree.Add(30);
            binaryTree.Add(25);
            binaryTree.Add(35);
            binaryTree.Add(80);
            binaryTree.Add(75);

            binaryTree.TraversePreorder(binaryTree.Root);
        }
    }
}