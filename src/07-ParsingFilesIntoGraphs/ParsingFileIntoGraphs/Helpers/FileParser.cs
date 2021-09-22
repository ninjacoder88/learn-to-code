using System;
using System.Collections.Generic;
using System.IO;

namespace ParsingFilesIntoGraphs
{
    public class FileParser
    {
        public IEnumerable<Item> ParseFile(string filePath)
        {
            foreach(var fileLine in File.ReadAllLines(filePath))
            {
                var splitFileLine = fileLine.Split(",", StringSplitOptions.None);

                yield return new Item 
                            {
                                StartCity = splitFileLine[0], 
                                EndCity = splitFileLine[1], 
                                Distance = decimal.Parse(splitFileLine[2])
                            };
            }
        }
    }
}