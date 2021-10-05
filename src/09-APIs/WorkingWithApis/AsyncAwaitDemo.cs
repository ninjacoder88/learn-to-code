using System;
using System.Threading.Tasks;

namespace WorkingWithApis
{
    public class AsyncAwaitDemo
    {
        public void Demo01()
        {
            Console.WriteLine("Start");
            CountToX(5);
            Console.WriteLine("Finish");
        }

        public async Task Demo02Async()
        {
            Console.WriteLine("Start");
            await CountToX(5);
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