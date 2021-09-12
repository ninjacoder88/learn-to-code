using System;
using System.IO;

namespace DataProcessing
{
    public class DirectoryDemo
    {
        private const string DemoPath = @"D:\git\learn-to-code\src\06-DataProcessing\data";

        //enumerate directories
        public void Demo01()
        {
            var directories = Directory.EnumerateDirectories(DemoPath);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }
        }

        //directory exists
        public void Demo02()
        {
            bool result = Directory.Exists(DemoPath);
            Console.WriteLine(result);
        }

        //create directory
        public void Demo03()
        {
            Directory.CreateDirectory(@$"{DemoPath}\ltc-demo");
        }

        //enumerate files
        public void Demo04()
        {
            var files = Directory.EnumerateFiles(DemoPath);
            foreach(var file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}