using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_09_PokemonTrainer
{
    public class Trainer
    {
        public Trainer(string name, List<Pokemon> pokemons)
        {
            Name = name;
            Pokemons = pokemons;
        }
        public string Name { get; set; }
        public int NumberOfBadges { get; set; } = 0;
        public List<Pokemon> Pokemons { get; set; }
    }
}
