namespace GameLibrary.Testing.SimulationRollback
{
    public class RollbackEnemy : IEnemy, IRollback
    {
        private readonly RollbackHistory<IEnemyPrototype> _enemyHistory;

        public RollbackEnemy(IEnemyPrototype enemy)
        {
            _enemyHistory = new RollbackHistory<IEnemyPrototype>(enemy);
        }

        public bool IsAlive => _enemyHistory.Current.IsAlive;

        public void TakeDamage(int damage)
        {
            _enemyHistory.Current.TakeDamage(damage);
        }

        public void StepBackwards(int steps)
        {
            _enemyHistory.StepBackwards(steps);
        }

        public void SaveCurrentStep()
        {
            _enemyHistory.SaveCurrentStep();
        }
    }
}
