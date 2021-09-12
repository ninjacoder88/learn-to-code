using System.Collections.Generic;

namespace DataStructures
{
    public class DictionaryDemo
    {
        //initialize and populate dictionary
        public void Demo01()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("turn", "move in a circular direction wholly or partly around an axis or point.");
            dictionary.Add("jump", "push oneself off a surface and into the air by using the muscles in one's legs and feet");
            dictionary.Dump();
        }

        //dictionaries can have values of any type
        public void Demo02()
        {
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();
            dictionary.Add("turn", new List<string>{
                "move in a circular direction wholly or partly around an axis or point.",
                "move (something) so that it is in a different position in relation to its surroundings or its previous position"
                });
            dictionary.Add("jump", new List<string>{
                "push oneself off a surface and into the air by using the muscles in one's legs and feet",
                "move suddenly and quickly in a specified way."
                });
            dictionary.Dump();
        }

        //important methods on dictionary
        public void Demo03()
        {
            List<string> list = new List<string>{"A", "B", "C", "D", "A", "A", "B"};

            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (var item in list)
            {
                if(!dictionary.ContainsKey(item))
                    dictionary.Add(item, 0);

                dictionary[item]++;
            }
            dictionary.Dump();
        }
    }
}