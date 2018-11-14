namespace FactoryPatternExample.Characters
{
    public class Cyclops : Character
    {
        public Cyclops() : base()
        {
            _healthPoints = 500;
            _manaPoints = 0;
            _hitPoints = 5;
        }

        public override string Weapon
        {
            get
            {
                return "Fist";
            }
        }

        public override int Attack()
        {
            return _hitPoints;
        }

        public override int GetAttackPoints()
        {
            return _hitPoints;
        }

        public override string ToString()
        {
            return "Cyclops";
        }
    }
}
