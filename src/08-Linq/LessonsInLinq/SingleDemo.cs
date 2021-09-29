using System;
using System.Linq;

namespace LessonsInLinq
{
    public class SingleDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            if(salesOrders.Count > 1)
                throw new System.Exception("More than one item");

            Console.WriteLine(salesOrders[0]);
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            Console.WriteLine(salesOrders.Single());
        }

        public void Demo03()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            SalesOrder found = null;
            foreach(var salesOrder in salesOrders)
            {
                if(salesOrder.Total > 9000m)
                {
                    if(found == null)
                        found = salesOrder;
                    else
                        throw new System.Exception("More than one item");
                }
            }

            if(found == null)
                throw new System.Exception("No items found");

            Console.WriteLine(found);
        }

        public void Demo04()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            Console.WriteLine(salesOrders.Single(x => x.Total > 9000m));
        }
    }
}