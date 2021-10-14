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
            
            int totalSales = 0;
            foreach (var salesOrder in salesOrders)
            {
                totalSales += salesOrder.Total;
            }
            Console.WriteLine(totalSales);
        }
    }
}
