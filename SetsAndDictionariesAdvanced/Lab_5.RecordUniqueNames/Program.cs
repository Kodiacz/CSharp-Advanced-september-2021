﻿using System;
using System.Collections.Generic;

namespace Lab_5.RecordUniqueNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNames = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();

            for (int i = 0; i < numberOfNames; i++)
            {
                string name = Console.ReadLine();
                names.Add(name);
            }

            Console.WriteLine(string.Join("\n", names));
        }
    }
}
