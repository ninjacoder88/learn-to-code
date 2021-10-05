<Query Kind="Program" />

void Main()
{
	Random r = new Random();
	
	List<string> companies = new List<string>{"Moderna", "Pfizer", "Johnson & Johnson"};
	
	for(int i = 0; i < 50; i++)
	{
		int companyId = r.Next(0,3);
		
		int wholeDollar = r.Next(100, 10000);
		int cents = r.Next(0, 100);
		
		string company = companies[companyId];
		decimal value = wholeDollar + (cents / 100.0m);
		string str  ="salesOrders.Add(new SalesOrder { Id = " + i+1 + ", CustomerName = \"" + company + "\", Total = " + value + "m });";
		str.Dump();
	}
}

// You can define other methods, fields, classes and namespaces here
