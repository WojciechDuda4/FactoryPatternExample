namespace FactoryPatternExample.Characters
{
    public class Sorcerer : Character
    {
        public Sorcerer() : base()
        {
            _healthPoints = 80;
            _manaPoints = 200;
            _hitPoints = 50;
        }

        public override string Weapon
        {
            get
            {
                return "Wand";
            }
        }

        public override int Attack()
        {
            if (_manaPoints >= 40)
            {
                _manaPoints -= 40;
                return _hitPoints;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Sorcerer";
        }
    }
}
