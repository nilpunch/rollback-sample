namespace GameLibrary.Testing.SimulationRollback
{
    public interface IEnemy
    {
        bool IsAlive { get; }

        void TakeDamage(int damage);
    }
}
