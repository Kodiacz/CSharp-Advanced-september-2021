using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise_09_PokemonTrainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> trainers = new Dictionary<string, Trainer>();

            while (true)
            {
                string[] trainersInfo = Console.ReadLine().Split();

                if (trainersInfo[0] == "Tournament")
                {
                    break;
                }

                string trainerName = trainersInfo[0];
                string pokemonName = trainersInfo[1];
                string pokemonElement = trainersInfo[2];
                int pokemonHealth = int.Parse(trainersInfo[3]);

                if (!trainers.ContainsKey(trainerName))
                {
                    trainers.Add(trainerName, new Trainer(trainerName, new List<Pokemon> { new Pokemon(pokemonName, pokemonElement, pokemonHealth) }));
                }
                else
                {
                    trainers[trainerName].Pokemons.Add(new Pokemon(pokemonName, pokemonElement, pokemonHealth));
                }
            }

            while (true)
            {
                string command = Console.ReadLine();

                if (command == "End")
                {
                    break;
                }

                foreach (var trainer in trainers)
                {
                    //bool checkIfHasNoElement = false;
                    //for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                    //{
                    //    if (trainer.Value.Pokemons[i].Element == command)
                    //    {
                    //        trainer.Value.NumberOfBadges++;
                    //        checkIfHasNoElement = false;
                    //        break;
                    //    }
                    //    else
                    //    {
                    //        checkIfHasNoElement = true;
                    //    }
                    //}

                    //if (checkIfHasNoElement)
                    //{
                    //    for (int i = 0; i < trainer.Value.Pokemons.Count; i++)
                    //    {
                    //        trainer.Value.Pokemons[i].Health -= 10;

                    //        if (trainer.Value.Pokemons[i].Health <= 0)
                    //        {
                    //            trainer.Value.Pokemons.Remove(trainer.Value.Pokemons[i]);
                    //        }
                    //    }
                    //}

                    if (trainer.Value.Pokemons.Any(x => x.Element == command))
                    {
                        trainer.Value.NumberOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Value.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                    }

                    trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                }
            }

            trainers = trainers.OrderByDescending(x => x.Value.NumberOfBadges).ToDictionary(x => x.Key, x => x.Value);

            foreach (var trainer in trainers.Values)
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumberOfBadges} {trainer.Pokemons.Count}");
            }
        }
    }
}
