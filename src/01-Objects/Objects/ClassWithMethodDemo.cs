namespace Objects
{
    public class ClassWithMethodDemo
    {
        public void Demo01()
        {

        }
    }

    public class SalesOrder
    {
        public int Id {get;set;}
        
        public string Customer {get;set;}

        public List<LineItem> LineItems {get;set;}

        public void AddLineItem(LineItem lineItem)
        {
            LineItems.Add(lineItem);
        }

        public decimal CalculatePrice()
        {
            decimal total = 0;
            foreach (var item in LineItems)
            {
                total += item.Price;
            }
            return tota;
        }
    }

    public class LineItem
    {
        public int Id {get;set;}
        public string Name {get;set;}
        public decimal Price {get;set;}
    }
}