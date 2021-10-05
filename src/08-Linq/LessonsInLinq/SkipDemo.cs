using System.Collections.Generic;
using System.Linq;

namespace LessonsInLinq
{
    public class SkipDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            List<SalesOrder> results = new List<SalesOrder>();
            for(int i = 0; i < salesOrders.Count; i++)
            {
                if(i < 3)
                    continue;
                results.Add(salesOrders[i]);
            }

            results.Dump();
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.Skip(3).ToList().Dump();
        }
    }
}