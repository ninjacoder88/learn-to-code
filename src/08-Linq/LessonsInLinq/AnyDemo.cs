using System.Linq;

namespace LessonsInLinq
{
    public class AnyDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            foreach(var salesOrder in salesOrders)
            {
                if(salesOrder.Total > 500m)
                {
                    "true".Dump();
                    return;
                } 
            }
            "false".Dump();
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.Any(so => so.Total > 500m).Dump();
        }

        public void Demo03()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            if(salesOrders.Any())
                "Not Empty".Dump();
            else
                "Empty".Dump();
        }
    }
}