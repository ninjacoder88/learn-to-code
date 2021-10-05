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
	public List<Feature> Features {get;set;}
}

public class Feature
{
	public string Id { get; set; }
}