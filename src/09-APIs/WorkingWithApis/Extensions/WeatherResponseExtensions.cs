using System;

namespace WorkingWithApis
{
    public static class WeatherResponseExtensions
    {
        public static void Dump(this WeatherResponse weatherResponse)
        {
            Console.WriteLine("-----Features----");
            foreach(var feature in weatherResponse.Features)
            {
                Console.WriteLine($"Id: {feature.Id}");
                Console.WriteLine($"Properties:");
                Console.WriteLine($"\tStatus: {feature.Properties.Status}");
                Console.WriteLine($"\tEffective: {feature.Properties.Effective}");
                Console.WriteLine($"\tExpires: {feature.Properties.Expires}");
                Console.WriteLine($"\tSeverity: {feature.Properties.Severity}");
                Console.WriteLine($"\tCertainly: {feature.Properties.Certainty}");
                Console.WriteLine($"\tDescription: {feature.Properties.Description}");
                Console.WriteLine();
            }
        }
    }
}