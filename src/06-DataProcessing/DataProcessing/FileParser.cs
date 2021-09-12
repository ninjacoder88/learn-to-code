using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DataProcessing
{
    public class FileParser
    {
        private const string DemoPath = @"D:\git\learn-to-code\src\06-DataProcessing\data";

        public void ParseFile()
        {
            string path = Path.Combine(DemoPath, "city-distancewithtime.csv");
            string[] fileLines = File.ReadAllLines(path);
            List<string> fileLineList = fileLines.ToList();

            List<Item> items = new List<Item>();
            foreach(var fileLine in fileLineList)
            {
                var splitFileLine = fileLine.Split(",", StringSplitOptions.None);
                var start = splitFileLine[0];
                var end = splitFileLine[1];
                var distance = decimal.Parse(splitFileLine[2]);
                var time = int.Parse(splitFileLine[3]);
                Item item = new Item{StartCity = start, EndCity = end, Distance = distance, TimeInMinutes = time};
                items.Add(item);
            }
        }
    }

    public class Item
    {
        public string StartCity {get;set;}
        public string EndCity {get;set;}
        public decimal Distance {get;set;}
        public int TimeInMinutes {get;set;}
    }
}