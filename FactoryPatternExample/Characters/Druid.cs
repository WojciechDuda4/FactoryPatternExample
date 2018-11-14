namespace FactoryPatternExample.Characters
{
    public class Druid : Character
    {
        public Druid() : base()
        {
            _healthPoints = 100;
            _manaPoints = 200;
            _hitPoints = 30;
        }

        public override string Weapon
        {
            get
            {
                return "Rod";
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
                _manaPoints -= 20;
                return 0;
            }
        }

        public override string ToString()
        {
            return "Druid";
        }
    }
}
