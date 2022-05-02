using System;
using System.Collections.Generic;

namespace _06_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> names = new Queue<string>();

            while (true)
            {
                string name = Console.ReadLine();

                if (name != "Paid" && name != "End")
                {
                    names.Enqueue(name);
                }

                if (name == "Paid")
                {
                    while (names.Count > 0)
                    {
                        Console.WriteLine(names.Dequeue());
                    }
                }
                else if (name == "End")
                {
                    break;
                }
            }

            Console.WriteLine($"{names.Count} people remaining.");
        }
    }
}
