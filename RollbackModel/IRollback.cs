namespace GameLibrary.Testing.SimulationRollback
{
    public interface IRollback
    {
        void StepBackwards(int steps);
        void SaveCurrentStep();
    }
}
