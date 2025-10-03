namespace TeamServer.Domain.Entities.Listeners
{
    public abstract class Listener
    {
        public abstract string Name { get; }

        public abstract void Start();
        public abstract void Stop();
    }
}
