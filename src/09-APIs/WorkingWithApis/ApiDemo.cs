using System;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WorkingWithApis
{
    public class ApiDemo
    {
        public async Task Demo01Async()
        {
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://google.com");

                var response = await client.GetAsync("");
                var responseContent = await response.Content.ReadAsStringAsync();

                if(!response.IsSuccessStatusCode)
                    throw new Exception(responseContent);

                Console.WriteLine(responseContent);
            }
        }

        public async Task Demo02Async()
        {
            string responseContent = null;
            using(var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://api.weather.gov/alerts/active/area/LA");
                client.DefaultRequestHeaders.Add("User-Agent", "idt-sdf");

                var response = await client.GetAsync("");
                responseContent = await response.Content.ReadAsStringAsync();

                if(!response.IsSuccessStatusCode)
                    throw new Exception(responseContent);
            }

            var weatherResponse = JsonConvert.DeserializeObject<WeatherResponse>(responseContent);
            weatherResponse.Dump();
        }
    }
}