namespace GameLibrary.Testing.SimulationRollback
{
    public class EnemyAlarm : IUpdate
    {
        private readonly IEnemy _enemy;

        public EnemyAlarm(IEnemy enemy)
        {
            _enemy = enemy;
        }

        public void Update(long timeMilliseconds)
        {
            // Looking for enemies...
        }
    }
}
