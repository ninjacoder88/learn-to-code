using System.Collections.Generic;
using System.Linq;

namespace LessonsInLinq
{
    public class ChainingDemo
    {
        public void Demo01()
        {
            var salesOrders = new SalesOrderLoader().LoadMoreSalesOrders();

            int skipped = 0;
            int taken = 0;
            SalesOrder[] tempResults = new SalesOrder[10];
            for(int i = 0; i < salesOrders.Count; i++)
            {
                var salesOrder = salesOrders[i];

                if(salesOrder.CustomerName != "Moderna")
                    continue;

                if(skipped < 1)
                {
                    skipped++;
                    continue;
                }

                if(taken >= 10)
                    break;

                for(int j = 0; j < tempResults.Length; j++)
                {
                    if(tempResults[j] == null)
                    {
                        tempResults[j] = salesOrder;
                        break;
                    }
                    if(tempResults[j].Total > salesOrder.Total)
                    {
                        for(int k = tempResults.Length - 1; k > j; k--)
                        {
                            if(tempResults[k] == null && tempResults[k-1] == null)
                                continue;
                            tempResults[k] = tempResults[k-1];
                            tempResults[k-1] = null;
                        }
                        tempResults[j] = salesOrder;
                        break;
                    }
                }

                taken++;
            }
            
            List<int> list = new List<int>();
            foreach(var item in tempResults)
            {
                if(item == null)
                    continue;
                list.Add(item.Id);
            }

            list.Dump();
        }

        public void Demo02()
        {
            var salesOrders = new SalesOrderLoader().LoadMoreSalesOrders();

            salesOrders.Where(x => x.CustomerName == "Moderna")
                    .Skip(1)
                    .Take(10)
                    .OrderBy(x => x.Total)
                    .Select(x => x.Id)
                    .ToList()
                    .Dump();
        }
    }
}