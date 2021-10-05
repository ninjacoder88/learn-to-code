using System.Collections.Generic;

namespace WorkingWithApis
{
    public class WeatherResponse
    {
        public List<Feature> Features {get;set;}
    }

    public class Feature
    {
        public string Id {get;set;}

        public Properties Properties {get;set;}
    }

    public class Properties
    {
        public string Effective {get;set;}
        public string Expires {get;set;}
        public string Status {get;set;}
        public string Description {get;set;}
    }
}