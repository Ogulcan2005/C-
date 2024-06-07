using System;

namespace PokemonBattleSimulator
{
    class Pokeball
    {
        public Charmander charmander;
        public bool hasCharmanderInside;

        public Pokeball(Charmander charmander)
        {
            
            if (charmander != null)
            {
                this.charmander = charmander;
                hasCharmanderInside = true;
            }
        }

        public Charmander Open()
        {
            if (hasCharmanderInside == true)
            {
                return this.charmander;
            }

            return null;
        }

        public void Close(Charmander charmander)
        {
            if (hasCharmanderInside == false)
            {
                this.charmander = charmander;
            }
        }
        public bool getcharmanderinside()
        {
            return hasCharmanderInside;
        }
    }
}