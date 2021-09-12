using System;

namespace DataProcessing
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryDemo directoryDemo = new DirectoryDemo();
            //directoryDemo.Demo01();
            //directoryDemo.Demo02();
            //directoryDemo.Demo03();
            //directoryDemo.Demo04();

            DirectoryInfoDemo directoryInfoDemo = new DirectoryInfoDemo();
            //directoryInfoDemo.Demo01();
            //directoryInfoDemo.Demo02();
            //directoryInfoDemo.Demo03();
            //directoryInfoDemo.Demo04();
            //directoryInfoDemo.Demo05();

            FileDemo fileDemo = new FileDemo();
            //fileDemo.Demo01();
            //fileDemo.Demo02();
            //fileDemo.Demo03();
            //fileDemo.Demo04();

            FileParser fileParser = new FileParser();
            //fileParser.ParseFile();
        }
    }
}
