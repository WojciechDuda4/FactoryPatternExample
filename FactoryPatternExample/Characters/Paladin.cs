namespace FactoryPatternExample.Characters
{
    class Paladin : Character
    {
        public Paladin() : base()
        {
            _healthPoints = 200;
            _manaPoints = 200;
            _hitPoints = 20;
        }

        public override string Weapon
        {
            get
            {
                return "Spear";
            }
        }

        public override int Attack()
        {
            if (_manaPoints >= 20)
            {
                _manaPoints -= 20;
                return _hitPoints;
            }
            else
            {
                return 0;
            }
        }

        public override string ToString()
        {
            return "Paladin";
        }
    }
}
