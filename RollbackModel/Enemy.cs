namespace GameLibrary.Testing.SimulationRollback
{
    public class Enemy : IEnemyPrototype
    {
        private readonly IEnemyWeapon _weapon;
        private int _currentHealth;

        public Enemy(int currentHealth, IEnemyWeapon weapon)
        {
            _currentHealth = currentHealth;
            _weapon = weapon;
        }

        public IEnemyPrototype Clone()
        {
            return new Enemy(_currentHealth, _weapon);
        }

        public bool IsAlive => _currentHealth > 0;

        public void TakeDamage(int damage)
        {
            _currentHealth -= damage;
        }
    }
}
