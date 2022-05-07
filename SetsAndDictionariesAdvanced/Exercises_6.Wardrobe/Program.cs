using System;
using System.Collections.Generic;

namespace Exercises_6.Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
5
Blue -> shoes
Blue -> shoes,shoes,shoes
Blue -> shoes,shoes
Blue -> shoes
Blue -> shoes,shoes
Red tanktop
             */


            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());
            string[] input;

            for (int i = 0; i < n; i++)
            {
                // input is split by regex expression
                input = Console.ReadLine().Split(" -> ");


                // the first part of the input is always the color
                string color = Convert.ToString(input[0]);

                // the rest of the input is the clothes in the wardrobe
                string[] clothes = input[1].Split(",");

                // checking if wordrobe contains the color
                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe.Add(color, new Dictionary<string, int>());

                    // checking if the color contains the clothes
                    for (int k = 0; k < clothes.Length; k++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[k]))
                        {
                            wardrobe[color].Add(clothes[k], 0);
                        }

                        wardrobe[color][clothes[k]]++;
                    }
                }
                else
                {
                    for (int k = 0; k < clothes.Length; k++)
                    {
                        if (!wardrobe[color].ContainsKey(clothes[k]))
                        {
                            wardrobe[color].Add(clothes[k], 0);
                        }

                        wardrobe[color][clothes[k]]++;
                    }
                }
            }

            input = Console.ReadLine().Split();
            string wantedColor = input[0];
            string wantedClothe = input[1];

            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var clothe in color.Value)
                {
                    if (color.Key == wantedColor && clothe.Key == wantedClothe)
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value} (found!)");
                    }
                    else
                    {
                        Console.WriteLine($"* {clothe.Key} - {clothe.Value}");
                    }
                }
            }
        }
    }
}
