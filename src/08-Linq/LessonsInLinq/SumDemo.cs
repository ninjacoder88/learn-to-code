using System.Linq;

namespace LessonsInLinq
{
    public class ClassName
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            decimal total = 0m;
            foreach(var salesOrder in salesOrders)
            {
                total += salesOrder.Total;
            }

            total.Dump();
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadSalesOrders();

            salesOrders.Sum(x => x.Total).Dump();
        }
    }
}