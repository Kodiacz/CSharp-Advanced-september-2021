using System;
using System.Collections.Generic;

namespace Lab_7.SoftUniParty
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vipGuests = new HashSet<string>();
            HashSet<string> regularGuests = new HashSet<string>();
            string input = "";


            while (true)
            {
                input = Console.ReadLine();

                if (input == "PARTY")
                {
                    break;
                }

                if (char.IsDigit(input[0]))
                {
                    vipGuests.Add(input);
                }
                else
                {
                    regularGuests.Add(input);
                }
            }

            while (true)
            {
                input = Console.ReadLine();

                if (vipGuests.Contains(input))
                {
                    vipGuests.Remove(input);
                }
                else if (regularGuests.Contains(input))
                {
                    regularGuests.Remove(input);
                }
                else if (input == "END")
                {
                    break;
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);

            if (vipGuests.Count > 0)
            {
                Console.WriteLine(string.Join("\n", vipGuests));
            }

            if (regularGuests.Count > 0)
            {
                Console.WriteLine(string.Join("\n", regularGuests));
            }
        }
    }
}
