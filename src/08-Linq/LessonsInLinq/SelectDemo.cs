using System.Collections.Generic;
using System.Linq;

namespace LessonsInLinq
{
    public class SelectDemo
    {
        public void Demo01()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();

            List<decimal> orderTotals = new List<decimal>();
            foreach(var salesOrder in salesOrders)
            {
                orderTotals.Add(salesOrder.Total);
            }

            orderTotals.Dump();
        }

        public void Demo02()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();
            salesOrders.Select(x => x.Total).ToList().Dump();
        }
    }
}