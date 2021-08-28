namespace Trees
{
    public class BinaryTreeDemo
    {
        //create a binary tree
        //discuss binary tree
        //discuss var
        //review generics
        public void Demo01()
        {
            var seven = new BinaryNode<int>(7);
            var six = new BinaryNode<int>(6);
            var five = new BinaryNode<int>(5);
            var four = new BinaryNode<int>(4);
            var three = new BinaryNode<int>(3){Left = six, Right = seven};
            var two = new BinaryNode<int>(2){Left = four, Right = five};
            var one = new BinaryNode<int>(1){Left = two, Right = three};

            BinaryTree<int> tree = new BinaryTree<int>(one);

            
        }
    }
}