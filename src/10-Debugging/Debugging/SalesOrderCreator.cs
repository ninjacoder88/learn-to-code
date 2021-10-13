using System;
using System.Collections.Generic;

namespace Debugging
{
    public class SalesOrderCreator
    {
        public List<SalesOrder> Create()
        {
            Random r = new Random();
            
            int salesOrderCount = r.Next(1, 10);
            
            List<SalesOrder> salesOrders = new List<SalesOrder>();
            for(int i = 0; i < salesOrderCount; i++)
            {
                var salesOrder = new SalesOrder { Id = i + 1};
                salesOrders.Add(salesOrder);
                
                int lineItemCount = r.Next(1,10);
                for(int j = 0; j < lineItemCount; j++)
                {
                    salesOrder.AddLineItem(new LineItem() {Id = j+1, Price = r.Next(1, 100), Quantity = r.Next(1, 5)});
                }
            }
            
            return salesOrders;
        }
    }
}