using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.PartyReservationFilterModule
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guestList = Console.ReadLine().Split().ToList();
            var predicates = new Dictionary<string, Predicate<string>>();

            string tokens = Console.ReadLine();

            while (tokens != "Print")
            {
                string[] commands = tokens.Split(";");
                string PRFMcommand = commands[0];
                string PRFMtype = commands[1];
                string criteria = commands[2];
                string key = commands[1] + "_" + commands[2];
                Predicate<string> predicate = GetPredicate(PRFMtype, criteria);

                if (PRFMcommand == "Add filter")
                {
                    if (!predicates.ContainsKey(key))
                    {
                        predicates.Add(key, predicate);
                    }
                }
                else
                {
                    if (predicates.ContainsKey(key))
                    {
                        predicates.Remove(key);
                    }
                }

                tokens = Console.ReadLine();
            }

            //foreach (var predicate in predicates)
            //{
            //    guestList.RemoveAll(predicate.Value);
            //}

            foreach (var (key, predicate) in predicates)
            {
                guestList.RemoveAll(predicate);
            }

            Console.WriteLine(string.Join(" ", guestList));
        }

        public static Predicate<string> GetPredicate(string type, string critaria)
        {
            if (type == "Starts with")
            {
                return name => name.StartsWith(critaria);
            }

            if (type == "Ends with")
            {
                return name => name.EndsWith(critaria);
            }

            if (type == "Contains")
            {
                return name => name.Contains(critaria);
            }

            int length = int.Parse(critaria);

            return name => name.Length == length;
        }
    }

}
