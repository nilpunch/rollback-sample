namespace GameLibrary.Testing.SimulationRollback
{
    public interface IPrototype<out T>
    {
        T Clone();
    }
}