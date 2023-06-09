﻿namespace Dictionary
{
    // Keys cannot be null and replicated
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,string> myDict = new Dictionary<string,string>();
            myDict.Add("active", "Ready to engage in physically energetic pursuits");
            myDict.Add("amazing", "causing great surprise");
            myDict.Add("qurantine", "place of isolation");

            string value;
            myDict.TryGetValue("active",out value);
            Console.WriteLine(value);

            foreach (KeyValuePair<string,string> kvp in myDict)
            {
                Console.WriteLine("Key is "+kvp.Key+" Value is "+kvp.Value);
            }
        }
    }
} 