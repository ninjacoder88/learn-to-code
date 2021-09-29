using System.Linq;

namespace LessonsInLinq
{
    public class AllDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            foreach(var salesOrder in salesOrders)
            {
                if(salesOrder.Total <= 500m)
                {
                    "false".Dump();
                    return;
                }
                "true".Dump();
            }
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.All(x => x.Total > 500m).Dump();
        }
    }
}