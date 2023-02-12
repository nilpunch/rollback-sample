using System;
using System.Collections.Generic;

namespace GameLibrary.Testing.SimulationRollback
{
    public class GameModel : IRollback, IUpdate
    {
        private readonly List<IRollback> _rollbackObjects = new List<IRollback>();
        private readonly List<IUpdate> _gameObjects = new List<IUpdate>();

        public GameModel()
        {
            var enemy = new RollbackEnemy(new Enemy(10, new EnemyWeapon()));

            // Something can freely depend on Enemy
            var enemyAlarm = new EnemyAlarm(enemy);

            _rollbackObjects.Add(enemy);
            _gameObjects.Add(enemyAlarm);
        }

        public void Update(long timeMilliseconds)
        {
            foreach (var gameObject in _gameObjects)
                gameObject.Update(timeMilliseconds);
        }

        public void StepBackwards(int steps)
        {
            foreach (var rollbackObject in _rollbackObjects)
                rollbackObject.StepBackwards(steps);
        }

        public void SaveCurrentStep()
        {
            foreach (var rollbackObject in _rollbackObjects)
                rollbackObject.SaveCurrentStep();
        }
    }
}
