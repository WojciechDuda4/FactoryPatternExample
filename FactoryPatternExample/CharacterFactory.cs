using FactoryPatternExample.Characters;
using FactoryPatternExample.Enemies;

namespace FactoryPatternExample
{
    public class CharacterFactory : ICharacterFactory
    {
        public Character CreateCharacter(CharacterType profesionType)
        {
            Character character = null;
            switch (profesionType)
            {
                case CharacterType.Druid:
                    character = new Druid();
                    break;
                case CharacterType.Sorcerer:
                    character = new Sorcerer();
                    break;
                case CharacterType.Paladin:
                    character = new Paladin();
                    break;
                case CharacterType.Knight:
                    character = new Knight();
                    break;
                case CharacterType.Gnome:
                    character = new Gnome();
                    break;
                case CharacterType.Cyclops:
                    character = new Cyclops();
                    break;
            }

            return character;
        }
    }
}
