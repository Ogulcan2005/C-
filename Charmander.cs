using System;

namespace PokemonBattleSimulator
{
    class Charmander
    {
        public string name;
        public string nickname;
        public string type;
        public string weakness;

        public Charmander(string name, string type, string weakness, string nickname)
        {
            this.name = name;
            this.type = type;
            this.weakness = weakness;
            this.nickname = nickname;
        }

        public string GetName()
        {
            return name;
        }

        public string GetNickname()
        {
            return nickname;
        }

        public string GetType()
        {
            return type;
        }

        public string GetWeakness()
        {
            return weakness;
        }

        public string BattleCry()
        {
            return nickname + ": " + name;
        }
    }
}
