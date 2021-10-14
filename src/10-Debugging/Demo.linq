<Query Kind="Program" />

void Main()
{
	SalesOrderCreator salesOrderCreator = new SalesOrderCreator();
	
	var salesOrders = salesOrderCreator.Create();
	
	int totalSales = 0;
	foreach (var salesOrder in salesOrders)
	{
		totalSales += salesOrder.Total;
	}
	totalSales.Dump();
}

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
		LineItems.Add(lineItem);
		Total += lineItem.Price * lineItem.Quantity;
	}
}

public class LineItem
{
	public int Id {get;set;}
	
	public int Price {get;set;}
	
	public int Quantity {get;set;}
}