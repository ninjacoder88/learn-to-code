using System;
using System.Threading.Tasks;

namespace WorkingWithApis
{
    public class AsyncAwaitDemo
    {
        public void Demo01()
        {
            Console.WriteLine("Start");
            CountToX(10);
            Console.WriteLine("Finish");
        }

        public async Task Demo02Async()
        {
            Console.WriteLine("Start");
            await CountToX(1000);
            Console.WriteLine("Finish");
        }

        public async Task Demo03()
        {
            Console.WriteLine("Start");
            await CountToX(10);
            await CountToX(10);
            Console.WriteLine("Finish");
        }

        private Task CountToX(int x)
        {
            return Task.Factory.StartNew(() => {
                for(int i = 0; i < x; i++)
                {
                    Console.WriteLine(i);
                }
            });
        }
    }
}