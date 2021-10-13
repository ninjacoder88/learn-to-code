using System;
using System.Threading.Tasks;

namespace WorkingWithApis
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await Task.CompletedTask;

            AsyncAwaitDemo asyncAwait = new AsyncAwaitDemo();
            //asyncAwait.Demo01();
            //await asyncAwait.Demo02Async();
            //await asyncAwait.Demo03();

            JsonDemo jsonDemo = new JsonDemo();
            //jsonDemo.Demo01();
            //jsonDemo.Demo02();

            ApiDemo apiDemo = new ApiDemo();
            //await apiDemo.Demo01Async();
            await apiDemo.Demo02Async();
        }
    }
}
