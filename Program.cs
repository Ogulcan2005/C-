using System;

namespace PokemonBattleSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            string spelen = "ja";
            while (spelen != "nee")
            {
                Console.WriteLine("Geeft trainer een naam");
                string trainername = Console.ReadLine();
                Trainer trainer = new Trainer(trainername);
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(trainername + " geeft charmander een naam");
                    string nickname = Console.ReadLine();
                    Charmander charmander = new Charmander("Charmander", "Fire", "Water", nickname);
                    Pokeball pokeball = new Pokeball(charmander);

                    Charmander ball = pokeball.Open();
                    pokeball.Close(ball);
                    trainer.TakePokeball(pokeball);
                }

                Console.WriteLine("Geeft trainer 2 een naam");
                string trainer2name = Console.ReadLine();
                Trainer trainer2 = new Trainer(trainer2name);
                for (int i = 0; i < 6; i++)
                {
                    Console.WriteLine(trainer2name + " geeft charmander een naam");
                    string nickname2 = Console.ReadLine();
                    Charmander charmander2 = new Charmander("Charmander", "Fire", "Water", nickname2);
                    Pokeball pokeball2 = new Pokeball(charmander2);

                    Charmander ball2 = pokeball2.Open();
                    pokeball2.Close(ball2);
                    trainer2.TakePokeball(pokeball2);
                }

            
                    for (int i = 0; i < 6; i++)
                    {
                        Charmander first = trainer.ThrowPokeball(i);
                        Charmander second = trainer2.ThrowPokeball(i);

                        trainer.ReturnPokemon(first, i);
                        trainer2.ReturnPokemon(second, i);
                    }

                    Console.WriteLine("wil je opnieuw spelen ja/nee ");
                    spelen = Console.ReadLine();
            }
        }
    }
}
