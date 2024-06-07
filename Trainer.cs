using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace PokemonBattleSimulator
{
    class Trainer
    {
        public string name;
        public List<Pokeball> belt;

        public Trainer(string name)
        {
            this.name = name;
            this.belt = new List<Pokeball>();
        }
        public void TakePokeball(Pokeball pokeball)
        {
            if (belt.Count <= 6)
            {
                belt.Add(pokeball);
            }
        }


        public Charmander ThrowPokeball(int index)
        {
            //get pokeball from belt
                Pokeball pokeball = belt[index];

            // the pokeball opens and charmander jumps out
            Charmander charmander = pokeball.Open();

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(charmander.BattleCry());
            }
            return charmander;
        }

        public void ReturnPokemon(Charmander charmander, int index)
        {
            Pokeball pokeball = belt[index];

            pokeball.Close(charmander);


        }
    }
}
