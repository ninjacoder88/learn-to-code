using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayDemo arrayDemo = new ArrayDemo();
            arrayDemo.Demo01();
            arrayDemo.Demo02();
            arrayDemo.Demo03();
            arrayDemo.Demo04();

            ListDemo listDemo = new ListDemo();
            listDemo.Demo01();
            listDemo.Demo02();
            listDemo.Demo03();
            listDemo.Demo04();

            StackDemo stackDemo = new StackDemo();
            stackDemo.Demo01();
            stackDemo.Demo02();
            stackDemo.Demo03();

            QueueDemo queueDemo = new QueueDemo();
            queueDemo.Demo01();
            queueDemo.Demo02();
            queueDemo.Demo03();

            LinkedListDemo linkedListDemo = new LinkedListDemo();
            linkedListDemo.Demo01();

            DictionaryDemo dictionaryDemo = new DictionaryDemo();
            dictionaryDemo.Demo01();
        }
    }
}
