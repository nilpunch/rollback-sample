using System.Collections.Generic;
using System.Linq;

namespace GameLibrary.Testing.SimulationRollback
{
    public class RollbackHistory<T> : IRollback where T : IPrototype<T>
    {
        private readonly List<T> _history;
        private T _current;

        public RollbackHistory(T initial)
        {
            _current = initial;
            _history = new List<T> { _current.Clone() };
        }

        public T Current => _current;

        public void StepBackwards(int steps)
        {
            _history.RemoveRange(_history.Count - 1 - steps, steps);
            _current = _history.Last().Clone();
        }

        public void SaveCurrentStep()
        {
            _history.Add(_current.Clone());
        }
    }
}
