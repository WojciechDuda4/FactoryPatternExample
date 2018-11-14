using FactoryPatternExample.Characters;
using System;

namespace FactoryPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Fight(CharacterType.Gnome);

            Fight(CharacterType.Cyclops);
        }

        static void Fight(CharacterType enemyType)
        {
            ICharacterFactory characterFactory = new CharacterFactory();
            Character enemy = characterFactory.CreateCharacter(enemyType);

            Console.WriteLine("Id�c drog� spotykasz {0}, chc�cego Ci� pokona�!", enemy.ToString());
            Console.WriteLine("Wybierz posta�, kt�ra Ci� obroni!");
            Console.WriteLine("1 - Druid");
            Console.WriteLine("2 - Sorcerer");
            Console.WriteLine("3 - Paladin");
            Console.WriteLine("4 - Knight");

            ConsoleKeyInfo userInput = Console.ReadKey();
            CharacterType profesionType = (CharacterType)(Convert.ToInt32(userInput.KeyChar.ToString()) - 1);

            Character defender = characterFactory.CreateCharacter(profesionType);

            Console.WriteLine("\n");

            while (defender.isAlive && enemy.isAlive)
            {
                enemy.GetHit(defender.Attack());
                Console.WriteLine("{0} uderzy� {1} za {2} u�ywaj�c {3}", defender.ToString(), enemy.ToString(), defender.GetAttackPoints(), defender.Weapon);

                if (enemy.isAlive)
                {
                    defender.GetHit(enemy.Attack());
                    Console.WriteLine("{0} uderzy� {1} za {2} u�ywaj�c {3}", enemy.ToString(), defender.ToString(), enemy.GetAttackPoints(), enemy.Weapon);
                }
                Console.WriteLine("\n");
            }

            Console.WriteLine("Bitw� wygrywa {0}", defender.isAlive ? defender.ToString() : enemy.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("Wci�nij dowolny klawisz by kontynuowa�...");
            Console.ReadKey();
        }
    }
}
