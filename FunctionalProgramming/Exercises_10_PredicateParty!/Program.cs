using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercises_10_PredicateParty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split().ToList();

            //Func<string, string, bool> startsWith = (name, text) => name.StartsWith(text);
            //Func<string, string, bool> endsWith = (name, text) => name.EndsWith(text);
            //Func<string, int, bool> isEqualToLenght = (name, length) => name.Length == length;

            //while (true)
            //{
            //    List<string> tokens = Console.ReadLine().Split().ToList();

            //    if (tokens[0] == "Party!")
            //    {
            //        break;
            //    }

            //    string command = tokens[0];
            //    string condition = tokens[1];

            //    if (command == "Remove")
            //    {
            //        string text = tokens[2];

            //        if (condition == "StartsWith")
            //        {
            //            if (guests.Count == 1 && guests[0].StartsWith(text))
            //            {
            //                guests.Remove(guests[0]);
            //            }

            //            guests = guests.Where(name => !startsWith(name, text)).ToList();
            //        }
            //        else if (condition == "EndsWith")
            //        {
            //            guests = guests.Where(name => !endsWith(name, text)).ToList();

            //            if (guests.Count == 1 && guests[0].EndsWith(text))
            //            {
            //                guests.Remove(guests[0]);
            //            }
            //        }
            //        else
            //        {
            //            int length = int.Parse(text);
            //            guests = guests.Where(name => !isEqualToLenght(name, length)).ToList();
            //        }
            //    }
            //    else
            //    {
            //        for (int i = 0; i < guests.Count; i++)
            //        {
            //            string text = tokens[2];

            //            if (condition == "StartsWith")
            //            {
            //                if (startsWith(guests[i], text))
            //                {
            //                    guests.Insert(i, guests[i]);
            //                    i++;
            //                }
            //            }
            //            else if (condition == "EndsWith")
            //            {
            //                if (endsWith(guests[i], text))
            //                {
            //                    guests.Insert(i, guests[i]);
            //                    i++;
            //                }
            //            }
            //            else
            //            {
            //                int length = int.Parse(text);

            //                if (isEqualToLenght(guests[i], length))
            //                {
            //                    guests.Insert(i, guests[i]);
            //                    i++;
            //                }
            //            }
            //        }
            //    }
            //}

            //if (guests.Count > 0)
            //{
            //    Console.WriteLine("{0} are going to the party! ", string.Join(", ", guests));
            //}
            //else
            //{
            //    Console.WriteLine("Nobody is going to the party!");
            //}

            string tokens = Console.ReadLine();

            while (tokens != "Party!")
            {
                string[] commands = tokens.Split();
                Predicate<string> predicate = GetPredicate(commands[1]);

                if (commands[0] == "Remove")
                {
                    guests.RemoveAll(predicate);
                }
                else
                {
                    List<string> doubledGuests = guests.FindAll(predicate); // TODO:

                    if (doubledGuests.Any())
                    {
                        int index = guests.FindIndex(predicate); // negotiat
                        guests.InsertRange(index, doubledGuests); // TODO: 
                    }

                }

                tokens = Console.ReadLine();
            }
        }

        public static Predicate<string> GetPredicate(string criteria)
        {
            if (criteria == "StartsWith")
            {
                return x => x.StartsWith(criteria);
            }

            if (criteria == "EndsWith")
            {
                return x => x.EndsWith(criteria);
            }

            int length = int.Parse(criteria);

            return x => x.Length == length;
        }
    }
}
