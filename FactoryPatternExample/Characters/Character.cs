namespace FactoryPatternExample.Characters
{
    public abstract class Character
    {
        public abstract string Weapon { get; }

        public abstract int Attack();

        public bool isAlive
        {
            get
            {
                if (_healthPoints <= 0)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }

        protected int _healthPoints, _manaPoints, _hitPoints;

        public Character()
        {
            
        }

        public void GetHit(int damage)
        {
            _healthPoints -= damage;
        }
        
        public virtual int GetAttackPoints()
        {
            if (_manaPoints <= 0)
            {
                return 0;
            }
            else
            {
                return _hitPoints;
            }
        }
    }
}
