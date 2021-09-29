<Query Kind="Program" />

void Main()
{
	var salesOrders = new SalesOrderLoader().LoadMoreSalesOrders();

	
}

public class SalesOrder
{
	public int Id { get; set; }
	public string CustomerName { get; set; }
	public decimal Total { get; set; }

	public override string ToString()
	{
		return $"Id: {Id}; Customer: {CustomerName}; Order Total: ${Total}";
	}
}

public class SalesOrderLoader
{
    public List<SalesOrder> LoadSalesOrders()
    {
        List<SalesOrder> salesOrders = new List<SalesOrder>();
        salesOrders.Add(new SalesOrder{Id = 1, CustomerName = "Moderna", Total = 432.32m});
        salesOrders.Add(new SalesOrder{Id = 2, CustomerName = "Pfizer", Total = 238.32m});
        salesOrders.Add(new SalesOrder{Id = 3, CustomerName = "Pfizer", Total = 483.43m});
        salesOrders.Add(new SalesOrder{Id = 4, CustomerName = "Moderna", Total = 343.95m});
        salesOrders.Add(new SalesOrder{Id = 5, CustomerName = "Johnson & Johnson", Total = 984.72m});
        salesOrders.Add(new SalesOrder{Id = 6, CustomerName = "Moderna", Total = 9845.42m});
        salesOrders.Add(new SalesOrder{Id = 7, CustomerName = "Moderna", Total = 263.27m});
        salesOrders.Add(new SalesOrder{Id = 8, CustomerName = "Pfizer", Total = 8765.47m});
        salesOrders.Add(new SalesOrder{Id = 9, CustomerName = "Johnson & Johnson", Total = 846.31m});
        salesOrders.Add(new SalesOrder{Id = 10, CustomerName = "Johnson & Johnson", Total = 871.84m});
        return salesOrders;
    }

    public List<SalesOrder> LoadMoreSalesOrders()
    {
        List<SalesOrder> salesOrders = new List<SalesOrder>();
        salesOrders.Add(new SalesOrder { Id = 01, CustomerName = "Moderna", Total = 9970.17m });
        salesOrders.Add(new SalesOrder { Id = 11, CustomerName = "Moderna", Total = 1251.84m });
        salesOrders.Add(new SalesOrder { Id = 21, CustomerName = "Moderna", Total = 2468.64m });
        salesOrders.Add(new SalesOrder { Id = 31, CustomerName = "Moderna", Total = 399.04m });
        salesOrders.Add(new SalesOrder { Id = 41, CustomerName = "Johnson & Johnson", Total = 8805.24m });
        salesOrders.Add(new SalesOrder { Id = 51, CustomerName = "Pfizer", Total = 5241.14m });
        salesOrders.Add(new SalesOrder { Id = 61, CustomerName = "Moderna", Total = 6861.48m });
        salesOrders.Add(new SalesOrder { Id = 71, CustomerName = "Johnson & Johnson", Total = 7627.58m });
        salesOrders.Add(new SalesOrder { Id = 81, CustomerName = "Johnson & Johnson", Total = 4548.54m });
        salesOrders.Add(new SalesOrder { Id = 91, CustomerName = "Johnson & Johnson", Total = 5370.53m });
        salesOrders.Add(new SalesOrder { Id = 101, CustomerName = "Pfizer", Total = 2589.77m });
        salesOrders.Add(new SalesOrder { Id = 111, CustomerName = "Moderna", Total = 7807.96m });
        salesOrders.Add(new SalesOrder { Id = 121, CustomerName = "Johnson & Johnson", Total = 7785.97m });
        salesOrders.Add(new SalesOrder { Id = 131, CustomerName = "Pfizer", Total = 1443.66m });
        salesOrders.Add(new SalesOrder { Id = 141, CustomerName = "Johnson & Johnson", Total = 2764.82m });
        salesOrders.Add(new SalesOrder { Id = 151, CustomerName = "Pfizer", Total = 7339.33m });
        salesOrders.Add(new SalesOrder { Id = 161, CustomerName = "Moderna", Total = 7194.27m });
        salesOrders.Add(new SalesOrder { Id = 171, CustomerName = "Moderna", Total = 2630.38m });
        salesOrders.Add(new SalesOrder { Id = 181, CustomerName = "Pfizer", Total = 4227.23m });
        salesOrders.Add(new SalesOrder { Id = 191, CustomerName = "Pfizer", Total = 2319.66m });
        salesOrders.Add(new SalesOrder { Id = 201, CustomerName = "Moderna", Total = 3955.7m });
        salesOrders.Add(new SalesOrder { Id = 211, CustomerName = "Moderna", Total = 6114.77m });
        salesOrders.Add(new SalesOrder { Id = 221, CustomerName = "Moderna", Total = 4894.1m });
        salesOrders.Add(new SalesOrder { Id = 231, CustomerName = "Moderna", Total = 8064.74m });
        salesOrders.Add(new SalesOrder { Id = 241, CustomerName = "Moderna", Total = 6480.54m });
        salesOrders.Add(new SalesOrder { Id = 251, CustomerName = "Johnson & Johnson", Total = 8798.49m });
        salesOrders.Add(new SalesOrder { Id = 261, CustomerName = "Johnson & Johnson", Total = 3612.71m });
        salesOrders.Add(new SalesOrder { Id = 271, CustomerName = "Moderna", Total = 4328.81m });
        salesOrders.Add(new SalesOrder { Id = 281, CustomerName = "Moderna", Total = 5469.99m });
        salesOrders.Add(new SalesOrder { Id = 291, CustomerName = "Pfizer", Total = 8719.36m });
        salesOrders.Add(new SalesOrder { Id = 301, CustomerName = "Johnson & Johnson", Total = 2109.55m });
        salesOrders.Add(new SalesOrder { Id = 311, CustomerName = "Moderna", Total = 2930.74m });
        salesOrders.Add(new SalesOrder { Id = 321, CustomerName = "Johnson & Johnson", Total = 8076.66m });
		salesOrders.Add(new SalesOrder { Id = 331, CustomerName = "Moderna", Total = 3756.24m });
		salesOrders.Add(new SalesOrder { Id = 341, CustomerName = "Moderna", Total = 9827.91m });
		salesOrders.Add(new SalesOrder { Id = 351, CustomerName = "Pfizer", Total = 8895.61m });
		salesOrders.Add(new SalesOrder { Id = 361, CustomerName = "Johnson & Johnson", Total = 5994.53m });
		salesOrders.Add(new SalesOrder { Id = 371, CustomerName = "Johnson & Johnson", Total = 8373.86m });
		salesOrders.Add(new SalesOrder { Id = 381, CustomerName = "Johnson & Johnson", Total = 1045.96m });
		salesOrders.Add(new SalesOrder { Id = 391, CustomerName = "Johnson & Johnson", Total = 8401.06m });
		salesOrders.Add(new SalesOrder { Id = 401, CustomerName = "Johnson & Johnson", Total = 8817.61m });
		salesOrders.Add(new SalesOrder { Id = 411, CustomerName = "Johnson & Johnson", Total = 5654.6m });
		salesOrders.Add(new SalesOrder { Id = 421, CustomerName = "Moderna", Total = 8559.35m });
		salesOrders.Add(new SalesOrder { Id = 431, CustomerName = "Johnson & Johnson", Total = 8554.07m });
		salesOrders.Add(new SalesOrder { Id = 441, CustomerName = "Johnson & Johnson", Total = 7144.98m });
		salesOrders.Add(new SalesOrder { Id = 451, CustomerName = "Pfizer", Total = 9705.44m });
		salesOrders.Add(new SalesOrder { Id = 461, CustomerName = "Johnson & Johnson", Total = 7434.65m });
		salesOrders.Add(new SalesOrder { Id = 471, CustomerName = "Pfizer", Total = 5544.27m });
		salesOrders.Add(new SalesOrder { Id = 481, CustomerName = "Johnson & Johnson", Total = 9790.36m });
		salesOrders.Add(new SalesOrder { Id = 491, CustomerName = "Johnson & Johnson", Total = 3700.19m });
		return salesOrders;
	}
}