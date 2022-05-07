using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_7_TheV_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
           EmilConrad joined The V-Logger
           VenomTheDoctor joined The V-Logger
           Saffrona joined The V-Logger
           Saffrona followed EmilConrad
           Saffrona followed VenomTheDoctor
           EmilConrad followed VenomTheDoctor
           VenomTheDoctor followed VenomTheDoctor
           Saffrona followed EmilConrad
           Statistics
           */
            var vLogger = new Dictionary<string, List<SortedSet<string>>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                if (input[0] == "Statistics")
                {
                    break;
                }

                string vloggerName = input[0];
                string command = input[1];

                switch (command)
                {
                    case "joined":
                        if (!vLogger.ContainsKey(vloggerName))
                        {
                            vLogger.Add(vloggerName, new List<SortedSet<string>> { new SortedSet<string>(), new SortedSet<string>() });
                        }
                        break;
                    case "followed":
                        string followedVlogger = input[2];

                        if (vLogger.ContainsKey(vloggerName) && vLogger.ContainsKey(followedVlogger))
                        {
                            if (vloggerName == followedVlogger)
                            {
                                continue;
                            }

                            vLogger[vloggerName][1].Add(followedVlogger);
                            vLogger[followedVlogger][0].Add(vloggerName);
                        }
                        break;
                }
            }

            vLogger = vLogger.OrderByDescending(x => x.Value[0].Count)
                             .ThenBy(x => x.Value[1].Count)
                             .ToDictionary(pair => pair.Key, pair => pair.Value);

            int numbering = 1;
            int maxFollowers = -1;
            string topFallowedVlogger = "";
            Console.WriteLine($"The V-Logger has a total of {vLogger.Keys.Count} vloggers in its logs.");

            foreach (var vlogger in vLogger)
            {
                if (vlogger.Value[0].Count > maxFollowers)
                {
                    maxFollowers = vlogger.Value[0].Count;
                    topFallowedVlogger = vlogger.Key;
                }
            }

            foreach (var vlogger in vLogger)
            {
                int followers = vlogger.Value[0].Count;
                int following = vlogger.Value[1].Count;

                Console.WriteLine($"{numbering}. {vlogger.Key} : {followers} followers, {following} following");

                if (vlogger.Key == topFallowedVlogger)
                {
                    foreach (var follower in vlogger.Value[0])
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                numbering++;
            }
        }
    }
}
