using System;
using System.Linq;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesOrderCreator salesOrderCreator = new SalesOrderCreator();
	
            var salesOrders = salesOrderCreator.Create();
            
            Console.WriteLine(salesOrders.Sum(x => x.Total));
        }
    }
}
