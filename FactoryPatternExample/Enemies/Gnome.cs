using FactoryPatternExample.Characters;

namespace FactoryPatternExample.Enemies
{
    public class Gnome : Character
    {
        public Gnome() : base()
        {
            _healthPoints = 100;
            _manaPoints = 0;
            _hitPoints = 20;
        }

        public override string Weapon
        {
            get
            {
                return "Teeth";
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
            return "Gnome";
        }
    }
}
