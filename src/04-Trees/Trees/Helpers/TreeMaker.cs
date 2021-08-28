namespace Trees
{
    public class TreeMaker
    {
        public Tree<int> Make()
        {
            var one = new Node<int>(1);
            var two = new Node<int>(2);
            var three = new Node<int>(3);
            var four = new Node<int>(4);
            var five = new Node<int>(5);
            var six = new Node<int>(6);
            var seven = new Node<int>(7);

            one.AddChild(two);
            one.AddChild(three);
            two.AddChild(four);
            two.AddChild(five);
            three.AddChild(six);
            three.AddChild(seven);

            return new Tree<int>(one);
        }
    }
}