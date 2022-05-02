using System;
using System.Collections.Generic;

namespace _5._6_SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(", ");
            Queue<string> songs = new Queue<string>();

            for (int i = 0; i < input.Length; i++)
            {
                songs.Enqueue(input[i]);
            }

            while (songs.Count > 0)
            {
                input = Console.ReadLine().Split();
                string command = input[0];

                if (command == "Add")
                {
                    string song = "";

                    for (int i = 1; i < input.Length; i++)
                    {
                        if (i == input.Length - 1)
                        {
                            song += input[i];
                            break;
                        }

                        song += input[i] + " ";
                    }

                    if (!songs.Contains(song))
                    {
                        songs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Play" && songs.Count > 0)
                {
                    songs.Dequeue();
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", songs));
                }

                if (songs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                }
            }
        }
    }
}
