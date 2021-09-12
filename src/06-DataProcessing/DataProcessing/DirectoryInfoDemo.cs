using System;
using System.IO;

namespace DataProcessing
{
    public class DirectoryInfoDemo
    {
        private const string DemoPath = @"D:\git\learn-to-code\src\06-DataProcessing\data";

        //enumerate directories
        public void Demo01()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(DemoPath);
            var directories = directoryInfo.EnumerateDirectories();
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        //directory exists
        public void Demo02()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(DemoPath);
            Console.WriteLine(directoryInfo.Exists);
        }

        //create directory
        public void Demo03()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(DemoPath);
            directoryInfo.CreateSubdirectory("ltc-demo");
        }

        //enumerate files
        public void Demo04()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(DemoPath);
            var files = directoryInfo.EnumerateFiles();//pass in pattern
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
        }

        //properites
        public void Demo05()
        {
            DirectoryInfo directoryInfo = new DirectoryInfo(@"C:\temp");
            Console.WriteLine($"CreationTime -> {directoryInfo.CreationTime}");
            Console.WriteLine($"FullName -> {directoryInfo.FullName}");
            Console.WriteLine($"LastWriteTime -> {directoryInfo.LastWriteTime}");
            Console.WriteLine($"Root -> {directoryInfo.Root}");
        }
    }
}