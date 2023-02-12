namespace GameLibrary.Testing.SimulationRollback
{
    public class EnemyWeapon : IEnemyWeapon
    {
        public IEnemyWeapon Clone()
        {
            return new EnemyWeapon();
        }
    }
}
