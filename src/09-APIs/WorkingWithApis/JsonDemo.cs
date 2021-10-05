using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WorkingWithApis
{
    public class JsonDemo
    {
        /*Serialization*/
        public void Demo01()
        {
            WeatherResponse response = new WeatherResponse 
            {
                Features = new List<Feature>
                {
                    new Feature{Id = "feature 1"}
                }
            };

            var json = JsonConvert.SerializeObject(response);
            Console.WriteLine(json);
        }

        /*Deserialization*/
        public void Demo02()
        {
            string json = "{features: [{id: 'feature 1'}]}";
            var response = JsonConvert.DeserializeObject<WeatherResponse>(json);
            Console.WriteLine(response.Features[0].Id);
        }
    }
}