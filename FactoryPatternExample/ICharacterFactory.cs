using FactoryPatternExample.Characters;

namespace FactoryPatternExample
{
    public interface ICharacterFactory
    {
        Character CreateCharacter(CharacterType profesionType);
    }
}
