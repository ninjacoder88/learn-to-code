using System;
using System.Collections.Generic;
using System.IO;

namespace DataProcessing
{
    public class FileDemo
    {
        private const string DemoPath = @"D:\git\learn-to-code\src\06-DataProcessing\data";

        //read all text
        public void Demo01()
        {
            string path = Path.Combine(DemoPath, "demo.txt");
            var fileText = File.ReadAllText(path);
            Console.WriteLine(fileText);
        }

        //read all lines
        public void Demo02()
        {
            string path = Path.Combine(DemoPath, "demo.txt");
            var fileLines = File.ReadLines(path);
            foreach(var fileLine in fileLines)
            {
                Console.WriteLine(fileLine);
            }
        }

        //write all text
        public void Demo03()
        {
            string path = Path.Combine(DemoPath, "empty.txt");
            File.WriteAllText(path, "This is a demo");
        }

        //write all lines
        public void Demo04()
        {
            string path = Path.Combine(DemoPath, "empty.txt");

            List<string> list = new List<string>();
            list.Add("Line 1");
            list.Add("Line 2");
            list.Add("Line 3");

            File.WriteAllLines(path, list);
        }
    }
}