using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace P04_SurbianUnleashed
{
    class SurbianUnleashed
    {
        static void Main(string[] args)
        {
            string pattern = @"([A-Za-z\s]+)\s@([A-Za-z\s]+)\s([0-9]+)\s([0-9]+)";
            Regex rgx = new Regex(pattern);

            StringBuilder inputData = new StringBuilder();

            string line = Console.ReadLine();

            while (line != "End")
            {
                inputData.Append(line.Trim());
                inputData.Append("");

                line = Console.ReadLine();
            }

            MatchCollection matches = rgx.Matches(inputData.ToString());

            var venueSingerDictionary = new Dictionary<string, Dictionary<string, int>>();

            foreach (Match match in matches)
            {
                string singerName = match.Groups[1].Value.Trim();
                string venue = match.Groups[2].Value;
                int ticketsPrice = int.Parse(match.Groups[3].Value);
                int ticketsCount = int.Parse(match.Groups[4].Value);

                if (!venueSingerDictionary.ContainsKey(venue))
                {
                    venueSingerDictionary[venue] = new Dictionary<string, int>();
                }

                if (!venueSingerDictionary[venue].ContainsKey(singerName))
                {
                    venueSingerDictionary[venue].Add(singerName, ticketsCount * ticketsPrice);
                }
                else
                {
                    venueSingerDictionary[venue][singerName] += ticketsCount * ticketsPrice;
                }
            }

            foreach (var venueSinger in venueSingerDictionary)
            {
                Console.WriteLine(venueSinger.Key);
                foreach (var entry in venueSinger.Value.OrderByDescending(x => x.Value))
                {
                    Console.WriteLine("#  {0} -> {1}", entry.Key, entry.Value);
                }
            }

        }
    }
}
