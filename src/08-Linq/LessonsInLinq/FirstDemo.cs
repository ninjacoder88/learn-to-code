using System;
using System.Linq;

namespace LessonsInLinq
{
    public class FirstDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            Console.WriteLine(salesOrders[0]);
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            Console.WriteLine(salesOrders.First());
        }

        public void Demo03()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            foreach(var salesOrder in salesOrders)
            {
                if(salesOrder.Total > 500m)
                {
                    Console.WriteLine(salesOrder);
                    return;
                }
            }
        }

        public void Demo04()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            Console.WriteLine(salesOrders.First(x => x.Total > 500m));
        }
    }
}