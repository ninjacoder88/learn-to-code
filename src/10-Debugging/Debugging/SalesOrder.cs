using System.Collections.Generic;

namespace Debugging
{
    public class SalesOrder
    {
        public SalesOrder()
        {
            LineItems = new List<LineItem>();
        }
        
        public int Id {get;set;}
        
        public List<LineItem> LineItems {get;}
        
        public int Total {get; private set;}
        
        public void AddLineItem(LineItem lineItem)
        {
            Total = lineItem.Price * lineItem.Quantity;
        }
    }
}