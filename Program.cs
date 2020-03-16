using System;
using System.Collections.Generic;
using System.Linq;

namespace assign_7
{
    class Program
    {

        static void Main(string[] args)
        {
            while(true)
            {
            var wordDict = new Dictionary<string, string> 
            {
            
            {"analyze", "discover or reveal (something) through detailed examination"},
            {"handle", "feel or manipulate with the hands"},
            {"browse", "survey goods for sale in a leisurely and casual way"},
            {"fabricate", "invent or concoct (something), typically with deceitful intent"},
            {"critique", "evaluate (a theory or practice) in a detailed and analytical way"},
            {"hull", "remove the hulls from (fruit, seeds, or grain)"},
            {"categorize", "place in a particular class or group"},
            {"hover", "remain in one place in the air"},
            {"cuddle", "hold close in one's arms as a way of showing love or affection"},
            {"affect", "touch the feelings of (someone); move emotionally"},
            {"define", "state or describe exactly the nature, scope, or meaning of"},
            {"eliminate", "completely remove or get rid of (something)"},
            {"carouse", "drink plentiful amounts of alcohol and enjoy oneself with others in a noisy, lively way"},
            {"elucidate", "make (something) clear; explain"},
            {"facilitate", "make (an action or process) easy or easier"},
            {"burrow", "advance into or through something solid by digging or making a hole"},
            {"falter", "start to lose strength or momentum"},
            {"gravitate", "move toward or be attracted to a place, person, or thing"},
            {"hurtle", "move or cause to move at a great speed, typically in a wildly uncontrolled manner"},
            {"assess", "evaluate or estimate the nature, ability, or quality of"}

            };

            Console.Write("Enter minimum number of letters for the word you'd like to search: ");
            int inNum = Int32.Parse(Console.ReadLine());
            var queryOne = wordDict.Where(entry => entry.Key.Length >= inNum).OrderBy(entry => entry.Key);
            Console.WriteLine($"Words that are {inNum} letters or more.\n");
            foreach(var entry in queryOne)
                Console.WriteLine($"Word: {entry.Key} \nDefinition: {entry.Value}\n\n");

            Console.Write("Enter letter you'd like to search: ");
            string input = Console.ReadLine().ToLower();
            var queryTwo = wordDict.Where(entry => entry.Key.Substring(0,1) == input).OrderBy(entry => entry.Key);
            Console.WriteLine($"Words starting with '{input}'.\n");
            foreach(var entry in queryTwo)
                Console.WriteLine($"Word: {entry.Key} \nDefinition: {entry.Value}\n\n");    
            }
        }

    }
}
