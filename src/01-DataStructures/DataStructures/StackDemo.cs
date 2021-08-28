using System.Collections;
using System.Collections.Generic;

namespace DataStructures
{
    public class StackDemo
    {
        //initialize and populate stack
        public void Demo01()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Dump();
        }

        //create a stack of different type and size
        public void Demo02()
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");

            stack.Dump();
        }

        //retrieve values from the stack
        public void Demo03()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            stack.Pop().Dump();
            stack.Pop().Dump();
            stack.Pop().Dump();
        }
    }
}