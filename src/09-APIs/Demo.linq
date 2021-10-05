<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <Namespace>System.Net.Http</Namespace>
  <Namespace>System.Threading.Tasks</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
</Query>

async Task Main()
{
	await Task.CompletedTask;
}

public async Task CallApiAsync()
{
	using(var client = new HttpClient())
	{
		client.BaseAddress = new Uri("");
		
		var response = await client.GetAsync("");
		var responseContent = await response.Content.ReadAsStringAsync();
		
		if(!response.IsSuccessStatusCode)
			throw new Exception(responseContent);
	}
}

public class WeatherResponse
{
	public List<Feature> Features { get; set; }
}

public class Feature
{
	public string Id { get; set; }

	public Properties Properties { get; set; }
}

public class Properties
{
	public string Effective { get; set; }
	public string Expires { get; set; }
	public string Status { get; set; }
	public string Description { get; set; }
}