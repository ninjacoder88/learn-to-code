using System.Collections.Generic;

namespace DataStructures
{
    public class ListDemo
    {
        //initialize and populate list
        public void Demo01()
        {
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);

            list.Dump();
        }

        //create list of different type and size
        public void Demo02()
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");

            list.Dump();
        }

        //initializer syntax
        public void Demo03()
        {
            List<int> list = new List<int>{2,4,6,8};

            list.Dump();
        }

        //get values from the list
        public void Demo04()
        {
            List<string> list = new List<string>();
            list.Add("A");
            list.Add("B");
            list.Add("C");

            list[2].Dump();
        }
    }
}