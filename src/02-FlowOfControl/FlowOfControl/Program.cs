using System;

namespace FlowOfControl
{
    class Program
    {
        static void Main(string[] args)
        {
            IfDemo ifDemo = new IfDemo();
            ifDemo.Demo01();

            ElseDemo elseDemo = new ElseDemo();
            elseDemo.Demo01();

            SwitchDemo switchDemo = new SwitchDemo();
            switchDemo.Demo01();

            ForDemo forDemo = new ForDemo();
            forDemo.Demo01();

            ForeachDemo foreachDemo = new ForeachDemo();
            foreachDemo.Demo01();

            WhileDemo whileDemo = new WhileDemo();
            whileDemo.Demo01();

            DoWhileDemo doWhileDemo = new DoWhileDemo();
            doWhileDemo.Demo01();
        }
    }
}
