using System;

namespace Trees
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeDemo binaryTreeDemo = new BinaryTreeDemo();
            binaryTreeDemo.Demo01();

            TreeDemo treeDemo = new TreeDemo();
            treeDemo.Demo01();

            var tree = new TreeMaker().Make();

            BreadthFirstSearch bfs = new BreadthFirstSearch();
            bfs.Traverse(tree);

            DepthFirstSearch dfs = new DepthFirstSearch();
            dfs.Traverse(tree);

            RecursiveDepthFirstSearch rdfs = new RecursiveDepthFirstSearch();
            rdfs.Traverse(tree.Root);
            rdfs.FindAllFilesWithExt(@"C:\", "*.txt");
        }
    }
}
