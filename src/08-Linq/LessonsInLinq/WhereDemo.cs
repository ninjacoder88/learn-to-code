using System.Collections.Generic;
using System.Linq;

namespace LessonsInLinq
{
    public class WhereDemo
    {
        public void Demo01()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();

            List<SalesOrder> modernaOrders = new List<SalesOrder>();
            foreach(var salesOrder in salesOrders)
            {
                if(salesOrder.CustomerName == "Moderna")
                    modernaOrders.Add(salesOrder);
            }

            modernaOrders.Dump();
        }

        public void Demo02()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();
            salesOrders.Where(x => x.CustomerName == "Moderna").ToList().Dump();
        }

        public void Demo03()
        {
            List<SalesOrder> salesOrders = new SalesOrderLoader().LoadSalesOrders();
            salesOrders.Where(x => x.CustomerName == "Moderna" && x.Total > 500m).ToList().Dump();
        }
    }
}