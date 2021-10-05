using System;

namespace LessonsInLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            WhereDemo whereDemo = new WhereDemo();
            //whereDemo.Demo01();
            //whereDemo.Demo02();
            //whereDemo.Demo03();

            SelectDemo selectDemo = new SelectDemo();
            //selectDemo.Demo01();
            //selectDemo.Demo02();

            AllDemo all = new AllDemo();
            //all.Demo01();
            //all.Demo02();

            AnyDemo any = new AnyDemo();
            //any.Demo01();
            //any.Demo02();
            //any.Demo03();

            SkipDemo skipDemo = new SkipDemo();
            //skipDemo.Demo01();
            //skipDemo.Demo02();

            TakeDemo takeDemo = new TakeDemo();
            //takeDemo.Demo01();
            //takeDemo.Demo02();

            FirstDemo firstDemo = new FirstDemo();
            //firstDemo.Demo01();
            //firstDemo.Demo02();
            //firstDemo.Demo03();
            //firstDemo.Demo04();

            SingleDemo singleDemo = new SingleDemo();
            //singleDemo.Demo01();
            //singleDemo.Demo02();
            //singleDemo.Demo03();
            //singleDemo.Demo04();

            OrderByDemo orderByDemo = new OrderByDemo();
            //orderByDemo.Demo01();
            //orderByDemo.Demo02();
            //orderByDemo.Demo03();
            //orderByDemo.Demo04();

            ChainingDemo chainingDemo = new ChainingDemo();
            chainingDemo.Demo01();
            //chainingDemo.Demo02();
        }
    }
}
