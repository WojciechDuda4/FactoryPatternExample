namespace FactoryPatternExample.Characters
{
    public class Knight : Character
    {
        public Knight() : base()
        {
            _healthPoints = 500;
            _manaPoints = 100;
            _hitPoints = 15;
        }

        public override string Weapon
        {
            get
            {
                return "Sword";
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
            return "Knight";
        }
    }
}
