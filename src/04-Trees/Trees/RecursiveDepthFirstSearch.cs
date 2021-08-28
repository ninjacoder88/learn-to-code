using System.IO;

namespace Trees
{
    public class RecursiveDepthFirstSearch
    {
        public void Traverse<T>(Node<T> node)
        {
            node.Dump();
            foreach(var child in node.Children)
                Traverse(child);
            node.Dump();
        }

        public void FindAllFilesWithExt(string root, string ext)
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(root);

            var matchingFiles = directoryInfo.EnumerateFiles(ext);
            foreach(var file in matchingFiles)
                file.Name.Dump();

            var directories = directoryInfo.EnumerateDirectories();
            foreach(var directory in directories)
                FindAllFilesWithExt(directory.FullName, ext);
        }
    }
}